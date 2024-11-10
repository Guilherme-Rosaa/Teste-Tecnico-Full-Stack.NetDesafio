using MediatR;
using TesteTecnico.Domain.Entities;

namespace TesteTecnico.Application.Queries
{
    public class GetNewLeadsQuery : IRequest<List<Lead>> { }
}
