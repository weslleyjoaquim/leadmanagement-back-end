using LeadManagement.Domain.Entities;
using LeadManagement.Domain.Enums;

namespace LeadManagement.Domain.Interfaces;

public interface ILeadRepository
{
    Task<List<Lead>> GetByStatusAsync(LeadStatus status);
    Task<Lead?> GetByIdAsync(int id);
    Task AddAsync(Lead lead);
    Task UpdateAsync(Lead lead);
    Task SaveChangesAsync();
}