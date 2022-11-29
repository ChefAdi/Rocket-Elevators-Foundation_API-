using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace RocketApi.Models
{
    public class batteries
    {
        public int Id { get; set; }
       
        public string? status { get; set; }
         public int EmployeeId { get; set; }
        public DateTime DateCommissioning { get; set; }
        public DateTime DateLastInspection { get; set; }
        public string CertificateOfOperations { get; set; } = null!;
        public string Information { get; set; } = null!;
        public string Notes { get; set; } = null!;
        public long? BuildingId { get; set; }
        [ForeignKey("BuildingId")]
        public Building Building { get; set; }
        public List<Column> Columns { get; set;}
        
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}