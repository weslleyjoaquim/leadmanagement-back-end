using LeadManagement.Application.Dtos;
using LeadManagement.Domain.Enums;

namespace LeadManagement.Application.Interfaces;

public interface ILeadService
{
    Task<List<LeadDto>> GetLeadsByStatusAsync(LeadStatus status);
    Task AcceptLeadAsync(int id);
    Task DeclineLeadAsync(int id);
}