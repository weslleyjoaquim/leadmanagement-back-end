using LeadManagement.Application.Interfaces;
using LeadManagement.Domain.Enums;
using Microsoft.AspNetCore.Mvc;

namespace LeadManagement.API.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class LeadsController : ControllerBase
{
    private readonly ILeadService _service;

    public LeadsController(ILeadService service)
    {
        _service = service;
    }

    [HttpGet("invited")]
    public async Task<IActionResult> GetInvited()
    {
        var leads = await _service.GetLeadsByStatusAsync(LeadStatus.Invited);
        return Ok(leads);
    }

    [HttpGet("accepted")]
    public async Task<IActionResult> GetAccepted()
    {
        var leads = await _service.GetLeadsByStatusAsync(LeadStatus.Accepted);
        return Ok(leads);
    }

    [HttpPost("accept/{id}")]
    public async Task<IActionResult> Accept(int id)
    {
        await _service.AcceptLeadAsync(id);
        return NoContent();
    }

    [HttpPost("decline/{id}")]
    public async Task<IActionResult> Decline(int id)
    {
        await _service.DeclineLeadAsync(id);
        return NoContent();
    }
}