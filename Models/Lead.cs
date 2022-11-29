using System;
using System.Collections.Generic;

namespace RocketApi
{
    public partial class Lead
    {
        public long Id { get; set; }
        public string FullNameContact { get; set; } = null!;
        public string CompanyName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string NameProject { get; set; } = null!;
        public string DescriptionProject { get; set; } = null!;
        public string Department { get; set; } = null!;
        public string Message { get; set; } = null!;
        // public byte[] File { get; set; } = null!;
        // public DateTime Date { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}