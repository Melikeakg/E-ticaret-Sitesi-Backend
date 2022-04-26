using Core.Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class ClothesDetailDto:IDto
    {
        public int ClothesId { get; set; }
        public int CategoryId { get; set; }
        public int ColorId { get; set; }
        public string ColorName { get; set; }
        public string CategoryName { get; set; }
        public int UnitPrice { get; set; }
        public string ClothesName { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public List<ClothesImage> Image { get; set; }


    }
}
