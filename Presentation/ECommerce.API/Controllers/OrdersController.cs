using ECommerce.Application.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderWriteRepository _orderWriteRepository;
        private readonly IOrderReadRepository _orderReadRepository;
        private readonly ICustomerWriteRepository _customerWriteRepository;

        public OrdersController(IOrderWriteRepository orderWriteRepository, ICustomerWriteRepository customerWriteRepository, IOrderReadRepository orderReadRepository)
        {
            _orderWriteRepository = orderWriteRepository;
            _customerWriteRepository = customerWriteRepository;
            _orderReadRepository = orderReadRepository;
        }

        [HttpGet]
        public Task Get()
        {
            return Task.CompletedTask;
            //var customerId = Guid.NewGuid();
            //await _customerWriteRepository.AddAsync(new() { Id = customerId, CustomerName = "Muhittin" });

            //await _orderWriteRepository.AddAsync(new() { Description = "Description 1", Address = "Address", CustomerId = customerId });
            //await _orderWriteRepository.AddAsync(new() { Description = "Description 2", Address = "Address2", CustomerId = customerId });
            //await _orderWriteRepository.SaveAsync();

            //var order = await _orderReadRepository.GetByIdAsync("26cb8859-15d8-4dbf-b368-6a8ab4934455");
            //order.Address = "Address 3";
            //await _orderWriteRepository.SaveAsync();
        }
    }
}
