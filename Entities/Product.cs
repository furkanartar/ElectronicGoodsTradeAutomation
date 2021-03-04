﻿using Core.Entities;

namespace Entities
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public short CategoryId { get; set; }
        public short SupplierId { get; set; }
        public string Name { get; set; }
        public short QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
    }
}