using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Clothes:IEntity
    {
        public int ClothesId { get; set; }
        public int CategoryId { get; set; }
        public int ColorId { get; set; }
        public string ClothesName { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitPrice { get; set; }
        public string Description { get; set; }

    }
}
