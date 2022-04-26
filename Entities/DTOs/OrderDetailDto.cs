using Core.Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class OrderDetailDto:IDto
    {
        public int OrderId { get; set; }
        public string ClothesName { get; set; }
        public string CategoryName { get; set; }
        public string ShipperName { get; set; }
        public int freight { get; set; }
        public int UnitPrice { get; set; }
        public string ColorName { get; set; }
        public string FullName { get; set; }
        public string ImagePath { get; set; }
        public List<ClothesImage> Images { get; set; }

    }
}
