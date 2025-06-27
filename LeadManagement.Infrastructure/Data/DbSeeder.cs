using LeadManagement.Domain.Entities;
using LeadManagement.Domain.Enums;

namespace LeadManagement.Infrastructure.Data;

public static class DbSeeder
{
    public static void Seed(AppDbContext context)
    {
        if (context.Leads.Any()) return;

        var leads = new List<Lead>
        {
            new Lead
            {
                Contact = new Contact
                {
                    FirstName = "Bill",
                    LastName = "",
                    PhoneNumber = "",
                    Email = ""
                },
                DateCreated = DateTime.Parse("2025-01-04T14:37:00"),
                Suburb = "Yanderra 2574",
                Category = "Painters",
                Description = "Need to paint 2 aluminum windows and a sliding glass door",
                Price = 62.00m,
                Status = LeadStatus.Invited
            },
            new Lead
            {
                Contact = new Contact
                {
                    FirstName = "Craig",
                    LastName = "",
                    PhoneNumber = "",
                    Email = ""
                },
                DateCreated = DateTime.Parse("2025-01-04T13:15:00"),
                Suburb = "Woolooware 2230",
                Category = "Interior Painters",
                Description = "internal walls 3 colours",
                Price = 49.00m,
                Status = LeadStatus.Invited
            },
            new Lead
            {
                Contact = new Contact
                {
                    FirstName = "Pete",
                    LastName = "Jones",
                    PhoneNumber = "0412345678",
                    Email = "fake@mailinator.com"
                },
                DateCreated = DateTime.Parse("2018-09-05T10:36:00"),
                Suburb = "Carramar 6031",
                Category = "General Building Work",
                Description = "Plaster exposed brick walls, square off 2 archways, expand pantry",
                Price = 26.00m,
                Status = LeadStatus.Accepted
            },
            new Lead
            {
                Contact = new Contact
                {
                    FirstName = "Chris",
                    LastName = "Sanderson",
                    PhoneNumber = "04987654321",
                    Email = "another.fake@hipmail.com"
                },
                DateCreated = DateTime.Parse("2018-08-30T11:14:00"),
                Suburb = "Quinns Rocks 6030",
                Category = "Home Renovations",
                Description = "Convert room into self-contained living area",
                Price = 32.00m,
                Status = LeadStatus.Accepted
            },
            new Lead
            {
                Contact = new Contact
                {
                    FirstName = "Jenna",
                    LastName = "Smith",
                    PhoneNumber = "0422000000",
                    Email = "jenna.smith@test.com"
                },
                DateCreated = DateTime.Parse("2025-01-02T09:00:00"),
                Suburb = "Bondi 2026",
                Category = "Tiling",
                Description = "Tile bathroom floor and walls",
                Price = 580.00m,
                Status = LeadStatus.Invited
            },
            new Lead
            {
                Contact = new Contact
                {
                    FirstName = "Mark",
                    LastName = "Taylor",
                    PhoneNumber = "0477000000",
                    Email = "mark.taylor@test.com"
                },
                DateCreated = DateTime.Parse("2025-01-03T10:30:00"),
                Suburb = "Manly 2095",
                Category = "Plumbing",
                Description = "Fix leaking pipe under kitchen sink",
                Price = 150.00m,
                Status = LeadStatus.Invited
            },
            new Lead
            {
                Contact = new Contact
                {
                    FirstName = "Emily",
                    LastName = "Clark",
                    PhoneNumber = "0466000000",
                    Email = "emily.clark@test.com"
                },
                DateCreated = DateTime.Parse("2024-12-25T16:00:00"),
                Suburb = "Parramatta 2150",
                Category = "Landscaping",
                Description = "Create garden bed along fence",
                Price = 320.00m,
                Status = LeadStatus.Invited
            },
            new Lead
            {
                Contact = new Contact
                {
                    FirstName = "Liam",
                    LastName = "Baker",
                    PhoneNumber = "0455000000",
                    Email = "liam.baker@test.com"
                },
                DateCreated = DateTime.Parse("2025-01-01T08:45:00"),
                Suburb = "Newtown 2042",
                Category = "Electricians",
                Description = "Install new ceiling fans",
                Price = 420.00m,
                Status = LeadStatus.Invited
            },
            new Lead
            {
                Contact = new Contact
                {
                    FirstName = "Sophia",
                    LastName = "Watson",
                    PhoneNumber = "0444000000",
                    Email = "sophia.watson@test.com"
                },
                DateCreated = DateTime.Parse("2024-12-31T11:30:00"),
                Suburb = "Surry Hills 2010",
                Category = "Cleaning",
                Description = "End of lease deep clean",
                Price = 200.00m,
                Status = LeadStatus.Declined
            },
            new Lead
            {
                Contact = new Contact
                {
                    FirstName = "Noah",
                    LastName = "Wilson",
                    PhoneNumber = "0433000000",
                    Email = "noah.wilson@test.com"
                },
                DateCreated = DateTime.Parse("2025-01-05T14:20:00"),
                Suburb = "Chatswood 2067",
                Category = "Roofing",
                Description = "Replace broken tiles on roof",
                Price = 800.00m,
                Status = LeadStatus.Accepted
            }
        };

        context.Leads.AddRange(leads);
        context.SaveChanges();
    }
}
