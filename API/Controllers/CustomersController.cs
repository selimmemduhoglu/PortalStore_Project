﻿using Business.Abstract;
using Castle.Core.Resource;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        ICustomerCheckService _customerService;

        public CustomersController(ICustomerCheckService customerService)
        {
            _customerService = customerService;
        }

        [HttpPost("add")]
        public IActionResult Add(Customer customer)
        {
            var result = _customerService.Add(customer);
            if (!result.Success) return BadRequest(result);

            return Ok(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Customer customer)
        {
            var result = _customerService.Update(customer);
            if (!result.Success) return BadRequest(result);

            return Ok(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Customer customer)
        {
            var result = _customerService.Delete(customer);
            if (!result.Success) return BadRequest(result);

            return Ok(result);
        }

        [HttpGet("getById")]
        public IActionResult GetById(int id)
        {
            var result = _customerService.GetById(id);
            if (!result.Success) return BadRequest(result);

            return Ok(result);
        }

        [HttpGet("getAll")]
        public IActionResult GetAll()
        {
            var result = _customerService.GetAll();
            if (!result.Success) return BadRequest(result);

            return Ok(result);
        }
    }
}

