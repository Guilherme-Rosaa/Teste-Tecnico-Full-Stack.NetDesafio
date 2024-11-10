using MediatR;
using TesteTecnico.Application.Queries;
using TesteTecnico.Domain.Entities;
using TesteTecnico.Domain.Enums;
using TesteTecnico.Infra.Repository.IRepository;

namespace TesteTecnico.Application.Handlers
{
    public class GetAcceptedLeadsQueryHandler : IRequestHandler<GetAcceptedLeadsQuery, List<Lead>>
    {
        private readonly ILeadRepository _leadRepository;

        public GetAcceptedLeadsQueryHandler(ILeadRepository leadRepository)
        {
            _leadRepository = leadRepository;
        }

        public async Task<List<Lead>> Handle(GetAcceptedLeadsQuery request, CancellationToken cancellationToken)
        {
            return await _leadRepository.GetLeadsByStatus(EnumStatusLead.Accepted);
        }
    }
}
