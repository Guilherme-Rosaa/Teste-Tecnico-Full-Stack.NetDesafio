using TesteTecnico.Domain.Entities;
using TesteTecnico.Domain.Enums;
using TesteTecnico.Infra.Context;

namespace TesteTecnico.Infra.Repository
{
    public static class SeedData
    {
        public static void Initialize(LeadContext context)
        {
            if (context.Leads.Any())
            {
                return;
            }

            var leads = new List<Lead>
            {
                new Lead
                {
                    Status = EnumStatusLead.New,
                    Price = 1000,
                    Category = "Web Design",
                    ContactFirstName = "John",
                    ContactFullName = "John Doe",
                    ContactPhoneNumber = "123-456-7890",
                    ContactEmail = "john@example.com",
                    DateCreated = DateTime.Now,
                    Suburb = "Downtown",
                    Description = "Website redesign project for a local business."
                },
                new Lead
                {
                    Status = EnumStatusLead.New,
                    Price = 2500,
                    Category = "Social Media Marketing",
                    ContactFirstName = "Sarah",
                    ContactFullName = "Sarah Johnson",
                    ContactPhoneNumber = "456-789-0123",
                    ContactEmail = "sarah@example.com",
                    DateCreated = DateTime.Now,
                    Suburb = "Uptown",
                    Description = "Comprehensive social media campaign management."
                },
                new Lead
                {
                    Status = EnumStatusLead.New,
                    Price = 1800,
                    Category = "SEO Optimization",
                    ContactFirstName = "Michael",
                    ContactFullName = "Michael Brown",
                    ContactPhoneNumber = "789-012-3456",
                    ContactEmail = "michael@example.com",
                    DateCreated = DateTime.Now,
                    Suburb = "Midtown",
                    Description = "SEO services for boosting online store visibility."
                },
                new Lead
                {
                    Status = EnumStatusLead.New,
                    Price = 3000,
                    Category = "Mobile App Development",
                    ContactFirstName = "Alice",
                    ContactFullName = "Alice White",
                    ContactPhoneNumber = "890-123-4567",
                    ContactEmail = "alice@example.com",
                    DateCreated = DateTime.Now,
                    Suburb = "Westside",
                    Description = "Developing a mobile app for a healthcare provider."
                },
                new Lead
                {
                    Status = EnumStatusLead.New,
                    Price = 1200,
                    Category = "Graphic Design",
                    ContactFirstName = "David",
                    ContactFullName = "David Lee",
                    ContactPhoneNumber = "345-678-9012",
                    ContactEmail = "david@example.com",
                    DateCreated = DateTime.Now,
                    Suburb = "Eastside",
                    Description = "Creating logos and visual branding materials."
                },
                new Lead
                {
                    Status = EnumStatusLead.New,
                    Price = 2200,
                    Category = "Content Writing",
                    ContactFirstName = "Emily",
                    ContactFullName = "Emily Clark",
                    ContactPhoneNumber = "567-890-1234",
                    ContactEmail = "emily@example.com",
                    DateCreated = DateTime.Now,
                    Suburb = "Southside",
                    Description = "Writing blog posts and website copy."
                },
                new Lead
                {
                    Status = EnumStatusLead.New,
                    Price = 4000,
                    Category = "E-commerce Development",
                    ContactFirstName = "Robert",
                    ContactFullName = "Robert King",
                    ContactPhoneNumber = "678-901-2345",
                    ContactEmail = "robert@example.com",
                    DateCreated = DateTime.Now,
                    Suburb = "Westend",
                    Description = "Building an e-commerce platform with payment integration."
                },
                new Lead
                {
                    Status = EnumStatusLead.New,
                    Price = 3500,
                    Category = "Video Production",
                    ContactFirstName = "Laura",
                    ContactFullName = "Laura Adams",
                    ContactPhoneNumber = "901-234-5678",
                    ContactEmail = "laura@example.com",
                    DateCreated = DateTime.Now,
                    Suburb = "Northside",
                    Description = "Producing promotional videos for a tech startup."
                },
                new Lead
                {
                    Status = EnumStatusLead.New,
                    Price = 1300,
                    Category = "Email Marketing",
                    ContactFirstName = "James",
                    ContactFullName = "James Taylor",
                    ContactPhoneNumber = "234-567-8901",
                    ContactEmail = "james@example.com",
                    DateCreated = DateTime.Now,
                    Suburb = "Lakeside",
                    Description = "Creating and managing email marketing campaigns."
                },
                new Lead
                {
                    Status = EnumStatusLead.New,
                    Price = 2700,
                    Category = "Photography",
                    ContactFirstName = "Olivia",
                    ContactFullName = "Olivia Davis",
                    ContactPhoneNumber = "345-678-9012",
                    ContactEmail = "olivia@example.com",
                    DateCreated = DateTime.Now,
                    Suburb = "Riverside",
                    Description = "Professional photography for real estate listings."
                },
                new Lead
                {
                    Status = EnumStatusLead.New,
                    Price = 1200,
                    Category = "Event Planning",
                    ContactFirstName = "Anna",
                    ContactFullName = "Anna Thompson",
                    ContactPhoneNumber = "111-222-3333",
                    ContactEmail = "anna@example.com",
                    DateCreated = DateTime.Now,
                    Suburb = "Greenwich",
                    Description = "Organizing a corporate retreat with catering and entertainment."
                },
                new Lead
                {
                    Status = EnumStatusLead.New,
                    Price = 500,
                    Category = "Landscaping",
                    ContactFirstName = "Mark",
                    ContactFullName = "Mark Spencer",
                    ContactPhoneNumber = "444-555-6666",
                    ContactEmail = "mark@example.com",
                    DateCreated = DateTime.Now,
                    Suburb = "Brookfield",
                    Description = "Garden design and maintenance for a residential property."
                },
                new Lead
                {
                    Status = EnumStatusLead.New,
                    Price = 3000,
                    Category = "IT Support",
                    ContactFirstName = "Susan",
                    ContactFullName = "Susan Carter",
                    ContactPhoneNumber = "777-888-9999",
                    ContactEmail = "susan@example.com",
                    DateCreated = DateTime.Now,
                    Suburb = "TechPark",
                    Description = "Setting up network and security systems for a small office."
                },
                new Lead
                {
                    Status = EnumStatusLead.New,
                    Price = 2500,
                    Category = "Interior Design",
                    ContactFirstName = "Tom",
                    ContactFullName = "Tom Lee",
                    ContactPhoneNumber = "123-987-6543",
                    ContactEmail = "tom@example.com",
                    DateCreated = DateTime.Now,
                    Suburb = "Downtown",
                    Description = "Home decor and layout planning for a new apartment."
                },
                new Lead
                {
                    Status = EnumStatusLead.New,
                    Price = 1600,
                    Category = "Legal Consulting",
                    ContactFirstName = "Karen",
                    ContactFullName = "Karen Smith",
                    ContactPhoneNumber = "234-567-1234",
                    ContactEmail = "karen@example.com",
                    DateCreated = DateTime.Now,
                    Suburb = "LegalDistrict",
                    Description = "Contract review and legal advice for small businesses."
                },
                new Lead
                {
                    Status = EnumStatusLead.New,
                    Price = 800,
                    Category = "Personal Training",
                    ContactFirstName = "Chris",
                    ContactFullName = "Chris Johnson",
                    ContactPhoneNumber = "345-678-2345",
                    ContactEmail = "chris@example.com",
                    DateCreated = DateTime.Now,
                    Suburb = "FitnessZone",
                    Description = "Customized fitness plan and coaching sessions."
                },
                new Lead
                {
                    Status = EnumStatusLead.New,
                    Price = 4500,
                    Category = "Architectural Design",
                    ContactFirstName = "Laura",
                    ContactFullName = "Laura Bell",
                    ContactPhoneNumber = "456-789-3456",
                    ContactEmail = "laura@example.com",
                    DateCreated = DateTime.Now,
                    Suburb = "CityCenter",
                    Description = "Designing a new residential building for urban development."
                },
                new Lead
                {
                    Status = EnumStatusLead.New,
                    Price = 750,
                    Category = "Pet Grooming",
                    ContactFirstName = "Sophia",
                    ContactFullName = "Sophia Brown",
                    ContactPhoneNumber = "567-890-4567",
                    ContactEmail = "sophia@example.com",
                    DateCreated = DateTime.Now,
                    Suburb = "Pet Haven",
                    Description = "Full grooming services for small to medium-sized pets."
                },
                new Lead
                {
                    Status = EnumStatusLead.New,
                    Price = 1900,
                    Category = "Photography",
                    ContactFirstName = "Eric",
                    ContactFullName = "Eric Blake",
                    ContactPhoneNumber = "678-901-5678",
                    ContactEmail = "eric@example.com",
                    DateCreated = DateTime.Now,
                    Suburb = "Old Town",
                    Description = "Wedding and event photography package."
                },
                new Lead
                {
                    Status = EnumStatusLead.New,
                    Price = 300,
                    Category = "Tutoring",
                    ContactFirstName = "Megan",
                    ContactFullName = "Megan Wilson",
                    ContactPhoneNumber = "789-012-6789",
                    ContactEmail = "megan@example.com",
                    DateCreated = DateTime.Now,
                    Suburb = "StudyHub",
                    Description = "Weekly math tutoring sessions for high school students."
                }
            };

            context.Leads.AddRange(leads);
            context.SaveChanges();
        }
    }
}
