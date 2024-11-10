using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TesteTecnico.Application.Commands;
using TesteTecnico.Application.Queries;
using TesteTecnico.Domain.Entities;
using TesteTecnico.Domain.Enums;
using TesteTecnico.Infra.Context;
using TesteTecnico.Service.IServices;

namespace TesteTecnico.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LeadController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LeadController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPatch("{id}/accept")]
        public async Task<ActionResult<List<Lead>>> AcceptLead(int id)
        {
            var command = new AcceptLeadCommand(id);
            await _mediator.Send(command);
            return await GetNewLeads();
        }

        [HttpPatch("{id}/decline")]
        public async Task<ActionResult<List<Lead>>> DeclineLead(int id)
        {
            var command = new DeclineLeadCommand(id);
            await _mediator.Send(command);
            return await GetNewLeads();
        }

        [HttpGet("new")]
        public async Task<ActionResult<List<Lead>>> GetNewLeads()
        {
            var query = new GetNewLeadsQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("accepted")]
        public async Task<ActionResult<List<Lead>>> GetAcceptedLeads()
        {
            var query = new GetAcceptedLeadsQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }
    }
}
