using TesteTecnico.Domain.Entities;
using TesteTecnico.Domain.Enums;
using TesteTecnico.Infra.Repository.IRepository;
using TesteTecnico.Service.IServices;

namespace TesteTecnico.Service
{
    public class LeadService : ILeadService
    {
        private readonly ILeadRepository _leadRepository;
        private readonly IEmailService _emailService;

        public LeadService(ILeadRepository leadRepository, IEmailService emailService)
        {
            _leadRepository = leadRepository;
            _emailService = emailService;
        }

        public async Task AcceptLead(int leadId)
        {
            var lead = await _leadRepository.GetByIdAsync(leadId);
            if (lead == null || !lead.CanBeAcceptedOrDeclined())
            {
                throw new InvalidOperationException("Lead cannot be accepted.");
            }
            lead.AcceptLead();
            await _leadRepository.SaveAsync(lead);
            await _emailService.SendEmailAsync("vendas@test.com", "Lead Accepted", $"Lead {leadId} has been accepted.");
        }

        public async Task DeclineLead(int leadId)
        {
            var lead = await _leadRepository.GetByIdAsync(leadId);
            if (lead == null || !lead.CanBeAcceptedOrDeclined())
            {
                throw new InvalidOperationException("Lead cannot be declined.");
            }
            lead.DeclineLead();
            await _leadRepository.SaveAsync(lead);
        }
    }
}
