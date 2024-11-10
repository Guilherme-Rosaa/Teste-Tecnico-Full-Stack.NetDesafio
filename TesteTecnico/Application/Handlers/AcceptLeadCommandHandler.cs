using MediatR;
using TesteTecnico.Application.Commands;
using TesteTecnico.Service.IServices;

namespace TesteTecnico.Application.Handlers
{
    public class AcceptLeadCommandHandler : IRequestHandler<AcceptLeadCommand>
    {
        private readonly ILeadService _leadService;

        public AcceptLeadCommandHandler(ILeadService leadService)
        {
            _leadService = leadService;
        }

        public async Task<Unit> Handle(AcceptLeadCommand request, CancellationToken cancellationToken)
        {
            await _leadService.AcceptLead(request.LeadId);
            return Unit.Value;
        }
    }
}
