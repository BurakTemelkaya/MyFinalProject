using Business.Abstract;
using Entites.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productservice;

        public ProductsController(IProductService productService)
        {
            _productservice = productService;
        }

        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _productservice.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        [HttpGet]
        public IActionResult Get(int id)
        {
            var result = _productservice.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Post(Product product)
        {
            var result = _productservice.Add(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}