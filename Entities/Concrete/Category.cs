using System;
using Core.Entities;

namespace Entities.Concrete
{
    public class Category : IEntity
    {
        public short Id { get; set; }
        public string CategoryName { get; set; }
    }
}