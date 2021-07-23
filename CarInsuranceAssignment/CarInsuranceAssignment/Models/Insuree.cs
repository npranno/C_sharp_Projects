
namespace CarInsuranceAssignment.Models
{
    using System;
    using System.Collections.Generic;

    public partial class Insuree
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public int CarYear { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public bool DUI { get; set; }
        public int SpeedingTickets { get; set; }
        public bool CovrageType { get; set; }
        public decimal Quote { get; set; }
    }
}