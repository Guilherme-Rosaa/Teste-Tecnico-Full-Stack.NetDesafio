using MediatR;
using TesteTecnico.Application.Queries;
using TesteTecnico.Domain.Entities;
using TesteTecnico.Domain.Enums;
using TesteTecnico.Infra.Repository.IRepository;

namespace TesteTecnico.Application.Handlers
{
    public class GetNewLeadsQueryHandler : IRequestHandler<GetNewLeadsQuery, List<Lead>>
    {
        private readonly ILeadRepository _leadRepository;

        public GetNewLeadsQueryHandler(ILeadRepository leadRepository)
        {
            _leadRepository = leadRepository;
        }

        public async Task<List<Lead>> Handle(GetNewLeadsQuery request, CancellationToken cancellationToken)
        {
            return await _leadRepository.GetLeadsByStatus(EnumStatusLead.New);
        }
    }
}
