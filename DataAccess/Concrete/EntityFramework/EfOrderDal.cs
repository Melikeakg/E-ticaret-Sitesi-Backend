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
    public class EfOrderDal : EfEntityRepositoryBase<Order, BoutiqueContext>, IOrderDal
    {
        public List<OrderDetailDto> GetOrderDetails(Expression<Func<OrderDetailDto, bool>> filter = null)
        {
            using (BoutiqueContext context = new BoutiqueContext())
            {
                var result = from order in context.Orders
                             join clothes in context.Clothes
                             on order.ClothesId equals clothes.ClothesId
                             join shipper in context.Shippers
                             on order.ShipperId equals shipper.ShipperId
                             join category in context.Categories
                             on clothes.CategoryId equals category.CategoryId
                             join color in context.Colors
                             on clothes.ColorId equals color.ColorId
                             join customer in context.Customers
                             on order.CustomerId equals customer.CustomerId
                             join user in context.Users
                             on customer.UserId equals user.Id
                             join clothesImage in context.ClothesImages
                             on clothes.ClothesId equals clothesImage.ClothesId

                             select new OrderDetailDto
                             {
                                 OrderId = order.OrderId,
                                 ClothesName = clothes.ClothesName,
                                 CategoryName = category.CategoryName,
                                 ShipperName = shipper.ShipperName,
                                 freight = shipper.Freight,
                                 UnitPrice = clothes.UnitPrice,
                                 ColorName = color.ColorName,
                                 FullName = user.FirstName + " " + user.LastName,
                                 ImagePath = clothesImage.ImagePath,
                                 Images = context.ClothesImages.Where(x => x.ClothesId == clothesImage.ClothesId).ToList()
                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
           
        }
    }
}
