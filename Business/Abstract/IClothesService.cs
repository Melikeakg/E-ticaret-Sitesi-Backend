using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IClothesService
    {
        IDataResult<List<Clothes>> GetAll();
        IDataResult<Clothes> GetByClothesId(int clothesId);
        IDataResult<List<Clothes>> GetClothesByColorId(int colorId);
        IDataResult<List<Clothes>> GetClothesByCategoryId(int categoryId);
        IResult Add(Clothes clothes);
        IResult Delete(Clothes clothes);
        IResult Update(Clothes clothes);
        IDataResult<List<ClothesDetailDto>> GetClothesDetailDto();
        IDataResult<List<ClothesDetailDto>> GetClothesDetailDtoByCategoryId(int categoryId);
        IDataResult<List<ClothesDetailDto>> GetClothesDetailDtoByColorId(int colorId);
        IDataResult<List<ClothesDetailDto>> GetClothesDetailDtoByCategoryAndColorId(int categoryId,int colorId);
        IDataResult<List<ClothesDetailDto>> GetClothesDetailDtoByClothesId(int clothesId);


    }
}
