using MediatR;

namespace TesteTecnico.Application.Commands
{
    public class AcceptLeadCommand : IRequest
    {
        public int LeadId { get; set; }

        public AcceptLeadCommand(int leadId)
        {
            LeadId = leadId;
        }
    }
}
