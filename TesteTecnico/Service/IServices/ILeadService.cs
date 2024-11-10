using TesteTecnico.Domain.Entities;
using TesteTecnico.Domain.Enums;

namespace TesteTecnico.Service.IServices
{
    public interface ILeadService
    {
        Task AcceptLead(int leadId);
        Task DeclineLead(int leadId);
    }
}
