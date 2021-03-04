using System;
using System.Runtime.InteropServices.ComTypes;
using Core.Entities;

namespace Entities
{
    public class Category : IEntity
    {
        public Int16 Id { get; set; }
        public string Name { get; set; }
    }
}