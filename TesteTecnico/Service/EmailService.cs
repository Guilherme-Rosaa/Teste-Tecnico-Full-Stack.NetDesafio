using TesteTecnico.Service.IServices;

namespace TesteTecnico.Service
{
    public class EmailService : IEmailService
    {
        public async Task SendEmailAsync(string to, string subject, string body)
        {
            var logMessage = $"Email sent to {to} with subject: {subject}\nBody: {body}\n\n";

            await File.AppendAllTextAsync("EmailLog.txt", logMessage);
        }
    }
}
