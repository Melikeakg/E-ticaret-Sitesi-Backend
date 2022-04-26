using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class ClothesManager : IClothesService
    {
        IClothesDal _clothesDal;

        public ClothesManager(IClothesDal clothesDal)
        {
            _clothesDal = clothesDal;
        }

        [ValidationAspect(typeof(ClothesValidator))]
        [SecuredOperation("admin")]
        public IResult Add(Clothes clothes)
        {
            _clothesDal.Add(clothes);
            return new SuccessResult(Messages.ClothesAdded);
        }

        [SecuredOperation("admin")]
        public IResult Delete(Clothes clothes)
        {
            _clothesDal.Delete(clothes);
            return new SuccessResult(Messages.ClothesDeleted);
        }

        public IDataResult<List<Clothes>> GetAll()
        {
            return new SuccessDataResult<List<Clothes>>(_clothesDal.GetAll(),Messages.ClothesListed);
        }

        public IDataResult<Clothes> GetByClothesId(int clothesId)
        {
            return new SuccessDataResult<Clothes>(_clothesDal.Get(c => c.ClothesId == clothesId));
        }

        public IDataResult<List<Clothes>> GetClothesByCategoryId(int categoryId)
        {
            return new SuccessDataResult<List<Clothes>>(_clothesDal.GetAll(c => c.CategoryId == categoryId).ToList());
        }

        public IDataResult<List<Clothes>> GetClothesByColorId(int colorId)
        {
            return new SuccessDataResult<List<Clothes>>(_clothesDal.GetAll(c => c.ColorId == colorId).ToList());
        }
     
        public IDataResult<List<ClothesDetailDto>> GetClothesDetailDto()
        {
            return new SuccessDataResult<List<ClothesDetailDto>>(_clothesDal.GetClothesDetailDtos());
        }

        public IDataResult<List<ClothesDetailDto>> GetClothesDetailDtoByCategoryAndColorId(int categoryId, int colorId)
        {
            return new SuccessDataResult<List<ClothesDetailDto>>(_clothesDal.GetClothesDetailDtos(c=>c.CategoryId==categoryId && c.ColorId==colorId));
        }

        public IDataResult<List<ClothesDetailDto>> GetClothesDetailDtoByCategoryId(int categoryId)
        {
            return new SuccessDataResult<List<ClothesDetailDto>>(_clothesDal.GetClothesDetailDtos(c=>c.CategoryId==categoryId));
        }

        public IDataResult<List<ClothesDetailDto>> GetClothesDetailDtoByClothesId(int clothesId)
        {
            return new SuccessDataResult<List<ClothesDetailDto>>(_clothesDal.GetClothesDetailDtos(c => c.ClothesId == clothesId));
        }

        public IDataResult<List<ClothesDetailDto>> GetClothesDetailDtoByColorId(int colorId)
        {
            return new SuccessDataResult<List<ClothesDetailDto>>(_clothesDal.GetClothesDetailDtos(c => c.ColorId == colorId));
        }

        [SecuredOperation("admin")]
        [ValidationAspect(typeof(ClothesValidator))]
        public IResult Update(Clothes clothes)
        {
            _clothesDal.Update(clothes);
            return new SuccessResult(Messages.ClothesUpdated);
        }
    }
}
