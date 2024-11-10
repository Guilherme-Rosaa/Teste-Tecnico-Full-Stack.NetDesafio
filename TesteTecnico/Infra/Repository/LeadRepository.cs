using Microsoft.EntityFrameworkCore;
using TesteTecnico.Domain.Entities;
using TesteTecnico.Domain.Enums;
using TesteTecnico.Infra.Context;
using TesteTecnico.Infra.Repository.IRepository;

namespace TesteTecnico.Infra.Repository
{
    public class LeadRepository : ILeadRepository
    {
        private readonly LeadContext _context;

        public LeadRepository(LeadContext context)
        {
            _context = context;
        }

        public async Task<Lead> GetByIdAsync(int id)
        {
            return await _context.Leads.FindAsync(id);
        }

        public async Task<List<Lead>> GetLeadsByStatus(EnumStatusLead status)
        {
            return await _context.Leads.Where(l => l.Status == status).ToListAsync();
        }

        public async Task SaveAsync(Lead lead)
        {
            _context.Leads.Update(lead);
            await _context.SaveChangesAsync();
        }
    }
}
