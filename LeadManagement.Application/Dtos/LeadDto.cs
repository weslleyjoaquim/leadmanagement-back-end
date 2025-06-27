namespace LeadManagement.Application.Dtos;

public class LeadDto
{
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string? LastName { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Email { get; set; }
    public DateTime DateCreated { get; set; }
    public string Suburb { get; set; } = null!;
    public string Category { get; set; } = null!;
    public string Description { get; set; } = null!;
    public decimal Price { get; set; }
}