using LeadManagement.Domain.Enums;

namespace LeadManagement.Domain.Entities;

public class Lead
{
    public int Id { get; set; }
    public int ContactId { get; set; }
    public Contact Contact { get; set; } = null!;
    public DateTime DateCreated { get; set; } = DateTime.Now;
    public string Suburb { get; set; } = null!;
    public string Category { get; set; } = null!;
    public string Description { get; set; } = null!;
    public decimal Price { get; set; }
    public LeadStatus Status { get; set; } = LeadStatus.Invited;
}