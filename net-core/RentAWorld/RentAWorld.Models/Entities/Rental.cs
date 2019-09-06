using System;

namespace RentAWorld.Models.Entities
{
    public class Rental
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal AskingPrice { get; set; }
        public bool Available { get; set; }
        public string Address { get; set; }
        public string City { get; set; }

        // Metadata / Database specific properties
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public string ModifiedBy { get; set; }
    }
}