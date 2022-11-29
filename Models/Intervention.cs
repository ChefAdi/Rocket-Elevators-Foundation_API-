using System;
using System.Collections.Generic;

namespace RocketApi
{
    public partial class Intervention
    {
        public long id { get; set; }
        public string? author { get; set; }
        public string? interventionDateStart { get; set; }
        public string? interventionDateEnd { get; set; }
        public string? result { get; set; }
        public string? report { get; set; }
        public string? status { get; set; }
        public long? customer_id { get; set; }
        public long? employee_id { get; set; }
        public long? building_id { get; set; }
        public long? batterie_id { get; set; }
        public long? column_id { get; set; }
        public long? elevator_id { get; set; }
    }
}