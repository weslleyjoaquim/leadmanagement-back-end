namespace LeadManagement.Domain.Entities;

public class Contact
{
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;
    public string Email { get; set; } = null!;
    public ICollection<Lead> Leads { get; set; } = new List<Lead>();
}