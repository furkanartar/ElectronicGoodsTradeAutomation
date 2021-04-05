using System;
using Core.Entities;
using Entities.Concrete;

namespace FormUI.Shared
{
    public class Cart:IEntity
    {
        public Product Product { get; set; }
        public short Quantity { get; set; }
    }
}