using Core.Entities;

namespace Entities.Concrete
{
    public class Supplier : IEntity
    {
        public short Id { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
    }
}