using System;
using System.Collections.Generic;

namespace RocketApi
{
    public partial class Customer
    {
        public long Id { get; set; }
        public DateTime? DateCreation { get; set; }
        public string CompanyName { get; set; } = null!;
        public string FullName { get; set; } = null!;
        public string ContactPhone { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Description { get; set; } = null!;
       // public string? CompanyHqAddresse { get; set; }
        public string? FullNameTechnicalAuthority { get; set; }
        public string? TechnicalAuthorityPhone { get; set; }
        public string? TechnicalAuthorityEmail { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public long? UserId { get; set; }
    }
}
