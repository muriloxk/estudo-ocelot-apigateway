using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace EstudosOcelotGateway.Orders.Api.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        public IActionResult GetOrders()
        {
            var o1 = new Order("ID1", 200);
            var o2 = new Order("ID2", 400);

            return Ok(new List<Order> { o1, o2 });
        }
    }

    public class Order
    {
        public string Id { get; set; }
        public decimal Amount { get; set; }

        public Order(string id, decimal amount)
        {
            Id = id;
            Amount = amount;
        }
    }
}
