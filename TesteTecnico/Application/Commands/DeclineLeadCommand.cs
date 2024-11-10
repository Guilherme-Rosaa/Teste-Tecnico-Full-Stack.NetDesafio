using MediatR;

namespace TesteTecnico.Application.Commands
{
    public class DeclineLeadCommand : IRequest
    {
        public int LeadId { get; set; }

        public DeclineLeadCommand(int leadId)
        {
            LeadId = leadId;
        }
    }
}
