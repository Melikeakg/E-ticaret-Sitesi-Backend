using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IClothesImageService
    {
        IResult Add(ClothesImage clothesImage, IFormFile formFile);
        IResult Update(ClothesImage clothesImage, IFormFile formFile);
        IResult Delete(ClothesImage clothesImage);
        IDataResult<List<ClothesImage>> GetAll();
        IDataResult<List<ClothesImage>> GetAllImagesByClothesId(int clothesId);

    }
}
