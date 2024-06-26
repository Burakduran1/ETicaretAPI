﻿using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        readonly private IProductWriteRepository _productWriteRepository;  //servisini talep edeilim.
        readonly private IProductReadRepository _productReadRepository;

        public ProductsController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
        }
        [HttpGet] // kullanılmayınca swagger tarafından hata alıyoruz.
        //public async void Get()
        public async Task Get()
        {
            //await _productWriteRepository.AddRangeAsync(new()
            //{
            //    new() {Id = Guid.NewGuid(), Name = "Product1", Price=100, CreatedDate=DateTime.UtcNow, Stock=10},
            //    new() {Id = Guid.NewGuid(), Name = "Product2", Price=200, CreatedDate=DateTime.UtcNow, Stock=20},
            //    new() {Id = Guid.NewGuid(), Name = "Product3", Price=300, CreatedDate=DateTime.UtcNow, Stock=30},
            //    new() {Id = Guid.NewGuid(), Name = "Product4", Price=400, CreatedDate=DateTime.UtcNow, Stock=40}

            //});
            //var count = await _productWriteRepository.SaveAsync();
            Product p = await _productReadRepository.GetByIdAsync("0c30d835-7360-4355-b5ff-1eb27d87d0ba", false);
            p.Name = "Ensar";
            await _productWriteRepository.SaveAsync();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            Product product = await _productReadRepository.GetByIdAsync(id);
            return Ok(product);
        }


    }
}
