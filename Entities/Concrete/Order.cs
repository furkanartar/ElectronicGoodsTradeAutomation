using System;
using Core.Entities;

namespace Entities.Concrete
{
    public class Order : IEntity
    {
        public int Id { get; set; }
        public short EmployeeId { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public short Quantity { get; set; }
        public DateTime OrderDate { get; set; }
    }
}