using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalIdentity { get; set; }
        public DateTime BirthDate { get; set; }
        public string Adress { get; set; }
        public string PhotoPath { get; set; }
        public string PhoneNumber { get; set; }
        public bool Enabled { get; set; }
    }
}