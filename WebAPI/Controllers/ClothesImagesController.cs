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
    public class ClothesImagesController : ControllerBase
    {
        IClothesImageService _clothesImageService;

        public ClothesImagesController(IClothesImageService clothesImageService)
        {
            _clothesImageService = clothesImageService;
        }

        [HttpPost("add")]
        public IActionResult Add([FromForm(Name = "Image")] IFormFile formFile, [FromForm]  ClothesImage clothesImage)
        {
            var result = _clothesImageService.Add(clothesImage, formFile);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete([FromForm] ClothesImage clothesImage)
        {
            var result = _clothesImageService.Delete(clothesImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update([FromForm(Name = "Image")] IFormFile formFile, [FromForm] ClothesImage clothesImage)
        {
            var result = _clothesImageService.Update(clothesImage, formFile);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _clothesImageService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getimagebyclothesid")]
        public IActionResult GetImageByClothesId(int clothesId)
        {
            var result = _clothesImageService.GetAllImagesByClothesId(clothesId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        
    }
}
