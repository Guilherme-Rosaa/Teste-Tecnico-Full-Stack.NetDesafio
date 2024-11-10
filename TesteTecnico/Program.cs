using MediatR;
using Microsoft.EntityFrameworkCore;
using TesteTecnico.Infra.Context;
using TesteTecnico.Infra.Repository;
using TesteTecnico.Infra.Repository.IRepository;
using TesteTecnico.Service;
using TesteTecnico.Service.IServices;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ILeadService, LeadService>();
builder.Services.AddScoped<IEmailService, EmailService>();
builder.Services.AddScoped<ILeadRepository, LeadRepository>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<LeadContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddMediatR(typeof(Program).Assembly);
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin", policy =>
    {
        policy.WithOrigins("https://localhost:4200")
              .AllowAnyMethod()
              .AllowAnyHeader()
              .AllowCredentials();
    });
});

var app = builder.Build();

app.UseCors("AllowSpecificOrigin");

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<LeadContext>();
    context.Database.Migrate();
    SeedData.Initialize(context);
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
