using TesteTecnico.Domain.Entities;
using TesteTecnico.Domain.Enums;

namespace TesteTecnico.Infra.Repository.IRepository
{
    public interface ILeadRepository
    {
        Task<Lead> GetByIdAsync(int id);
        Task<List<Lead>> GetLeadsByStatus(EnumStatusLead status);
        Task SaveAsync(Lead lead);
    }
}
