using MediatR;
using TesteTecnico.Application.Commands;
using TesteTecnico.Service.IServices;

namespace TesteTecnico.Application.Handlers
{
    public class DeclineLeadCommandHandler : IRequestHandler<DeclineLeadCommand>
    {
        private readonly ILeadService _leadService;

        public DeclineLeadCommandHandler(ILeadService leadService)
        {
            _leadService = leadService;
        }

        public async Task<Unit> Handle(DeclineLeadCommand request, CancellationToken cancellationToken)
        {
            await _leadService.DeclineLead(request.LeadId);
            return Unit.Value;
        }
    }
}
