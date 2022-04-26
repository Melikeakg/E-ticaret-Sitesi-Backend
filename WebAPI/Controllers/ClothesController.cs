using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClothesController : ControllerBase
    {
        IClothesService _clothesService;

        public ClothesController(IClothesService clothesService)
        {
            _clothesService = clothesService;
        }

        [HttpPost("add")]
        public IActionResult Add(Clothes clothes)
        {
            var result = _clothesService.Add(clothes);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Clothes clothes)
        {
            var result = _clothesService.Delete(clothes);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Clothes clothes)
        {
            var result = _clothesService.Update(clothes);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _clothesService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyclothesid")]
        public IActionResult GetByClothesId(int clothesId)
        {
            var result = _clothesService.GetByClothesId(clothesId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getclothesbycolorid")]
        public IActionResult GetClothesByColorId(int colorId)
        {
            var result = _clothesService.GetClothesByColorId(colorId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getclothesbycategoryid")]
        public IActionResult GetClothesByCategoryId(int categoryId)
        {
            var result = _clothesService.GetClothesByCategoryId(categoryId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getclothesdetails")]
        public IActionResult GetClothesDetails()
        {
            var result = _clothesService.GetClothesDetailDto();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getclothesdetailbycategoryid")]
        public IActionResult GetClothesDetailsByCategoryId(int categoryId)
        {
            var result = _clothesService.GetClothesDetailDtoByCategoryId(categoryId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

         [HttpGet("getclothesdetailbycolorid")]
         public IActionResult GetClothesDetailByColorId(int colorId)
        {
            var result = _clothesService.GetClothesDetailDtoByColorId(colorId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getclothesdetailbycategoryandcolorid")]
        public IActionResult GetClothesDetailByCategoryAndColorId(int categoryId,int colorId)
        {
            var result = _clothesService.GetClothesDetailDtoByCategoryAndColorId(categoryId, colorId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getclothesdetailbyclothesid")]
        public IActionResult GetClothesDetailByClothesId(int clothesId)
        {
            var result = _clothesService.GetClothesDetailDtoByClothesId(clothesId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
