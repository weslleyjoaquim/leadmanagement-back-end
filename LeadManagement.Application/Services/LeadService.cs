using LeadManagement.Application.Dtos;
using LeadManagement.Application.Interfaces;
using LeadManagement.Domain.Enums;
using LeadManagement.Domain.Interfaces;

namespace LeadManagement.Application.Services;

public class LeadService : ILeadService
{
    private readonly ILeadRepository _repository;

    public LeadService(ILeadRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<LeadDto>> GetLeadsByStatusAsync(LeadStatus status)
    {
        var leads = await _repository.GetByStatusAsync(status);
        return leads.Select(l => new LeadDto
        {
            Id = l.Id,
            FirstName = l.Contact.FirstName,
            LastName = l.Contact.LastName,
            PhoneNumber = l.Contact.PhoneNumber,
            Email = l.Contact.Email,
            DateCreated = l.DateCreated,
            Suburb = l.Suburb,
            Category = l.Category,
            Description = l.Description,
            Price = l.Price
        }).ToList();
    }

    public async Task AcceptLeadAsync(int id)
    {
        var lead = await _repository.GetByIdAsync(id) ?? throw new Exception("Lead not found");
        if (lead.Status != LeadStatus.Invited)
            throw new Exception("Only invited leads can be accepted");

        if (lead.Price > 500)
            lead.Price *= 0.9m;

        lead.Status = LeadStatus.Accepted;
        await _repository.UpdateAsync(lead);
        await _repository.SaveChangesAsync();

        await File.AppendAllTextAsync("accepted-leads.log", $"Lead {id} accepted.\n");
    }

    public async Task DeclineLeadAsync(int id)
    {
        var lead = await _repository.GetByIdAsync(id) ?? throw new Exception("Lead not found");
        lead.Status = LeadStatus.Declined;
        await _repository.UpdateAsync(lead);
        await _repository.SaveChangesAsync();
    }
}