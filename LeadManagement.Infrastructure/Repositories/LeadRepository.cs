using LeadManagement.Domain.Entities;
using LeadManagement.Domain.Enums;
using LeadManagement.Domain.Interfaces;
using LeadManagement.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace LeadManagement.Infrastructure.Repositories;

public class LeadRepository : ILeadRepository
{
    private readonly AppDbContext _context;

    public LeadRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Lead>> GetByStatusAsync(LeadStatus status)
    {
        return await _context.Leads.Include(l => l.Contact).Where(l => l.Status == status).ToListAsync();
    }

    public async Task<Lead?> GetByIdAsync(int id)
    {
        return await _context.Leads.Include(l => l.Contact).FirstOrDefaultAsync(l => l.Id == id);
    }

    public async Task AddAsync(Lead lead)
    {
        await _context.Leads.AddAsync(lead);
    }

    public async Task UpdateAsync(Lead lead)
    {
        _context.Leads.Update(lead);
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
}