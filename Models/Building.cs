using System;
using System.Collections.Generic;
namespace RocketApi
{
    public partial class Building
    {
        public long Id { get; set; }
        public string? AddressOfBuilding { get; set; }
        public string FullNameBuildingAdmin { get; set; } = null!;
        public string EmailBuildingAdmin { get; set; } = null!;
        public string PhoneBuildingAdmin { get; set; } = null!;
        public string FullNameTechnicalAuthority { get; set; } = null!;
        public string EmailTechnicalAuthority { get; set; } = null!;
        public string PhoneTechnicalAuthority { get; set; } = null!;
        public long? CustomerId { get; set; }
    
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
       // public object Batteries { get; internal set; }
    }
}