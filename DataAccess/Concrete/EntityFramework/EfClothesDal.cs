using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework

{
    public class EfClothesDal : EfEntityRepositoryBase<Clothes, BoutiqueContext>, IClothesDal
    {
        public List<ClothesDetailDto> GetClothesDetailDtos(Expression<Func<ClothesDetailDto, bool>> filter = null)
        {
            using (BoutiqueContext context = new BoutiqueContext())
            {
                var result = from clothes in context.Clothes
                             join clothesImage in context.ClothesImages
                             on clothes.ClothesId equals clothesImage.ClothesId

                             join category in context.Categories
                             on clothes.CategoryId equals category.CategoryId



                             join color in context.Colors
                             on clothes.ColorId equals color.ColorId

                             select new ClothesDetailDto
                             {
                                 ClothesId = clothes.ClothesId,
                                 CategoryId = clothes.CategoryId,
                                 ColorId = clothes.ColorId,
                                 CategoryName = category.CategoryName,
                                 ColorName = color.ColorName,
                                 Description = clothes.Description,
                                 UnitPrice = clothes.UnitPrice,
                                 ClothesName = clothes.ClothesName,
                                 ImagePath = clothesImage.ImagePath,
                                 Image = context.ClothesImages.Where(x => x.ClothesId == clothes.ClothesId).ToList()
                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
    }
}
