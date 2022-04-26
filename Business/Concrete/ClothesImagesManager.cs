using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Helper;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ClothesImagesManager : IClothesImageService
    {
        IClothesImageDal _clothesImageDal;

        public ClothesImagesManager(IClothesImageDal clothesImageDal)
        {
            _clothesImageDal = clothesImageDal;
        }

        public IResult Add(ClothesImage clothesImage, IFormFile formFile)
        {
            IResult result = BusinessRules.Run(CheckLimitClothesImage(clothesImage));
            if (result!=null)
            {
                return new ErrorResult(result.Message);
            }
            var imageResult = FileHelper.Add(formFile);
            if (!imageResult.Success)
            {
                return new ErrorResult(imageResult.Message);
            }
            clothesImage.ImagePath = imageResult.Message;
            _clothesImageDal.Add(clothesImage);
            return new SuccessResult(Messages.ClothesImageAdded);
        }

        public IResult Delete(ClothesImage clothesImage)
        {
            FileHelper.Delete(clothesImage.ImagePath);
            _clothesImageDal.Delete(clothesImage);
            return new SuccessResult(Messages.ClothesImageDeleted);
        }

        public IDataResult<List<ClothesImage>> GetAll()
        {
            var result = (_clothesImageDal.GetAll());
            return new SuccessDataResult<List<ClothesImage>>(result);
        }

        public IDataResult<List<ClothesImage>> GetAllImagesByClothesId(int clothesId)
        {
            var result = _clothesImageDal.GetAll(c => c.ClothesId == clothesId);
            if (result.Count==0)
            {
                return new ErrorDataResult<List<ClothesImage>>(Messages.NoImages);
            }
            return new SuccessDataResult<List<ClothesImage>>(result);
        }

        public IResult Update(ClothesImage clothesImage, IFormFile formFile)
        {
            var image = _clothesImageDal.Get(c => c.ClothesImageId == clothesImage.ClothesImageId);
            if (image == null)
            {
                return new ErrorResult(Messages.ImageNotFound);
            }

            var updatedFile = FileHelper.Update(formFile, image.ImagePath);
            if (!updatedFile.Success)
            {
                return new ErrorResult(updatedFile.Message);
            }
            clothesImage.ImagePath = updatedFile.Message;

            _clothesImageDal.Update(clothesImage);
            return new SuccessResult(Messages.ImagesUpdated);

        }

        private IResult CheckLimitClothesImage(ClothesImage clothesImage)
        {
            var result = _clothesImageDal.GetAll(c => c.ClothesId == clothesImage.ClothesId);
            if (result.Count>3)
            {
                return new ErrorResult(Messages.ClothesImageLimitExceded);
            }
            return new SuccessResult();
        }
    }
}
