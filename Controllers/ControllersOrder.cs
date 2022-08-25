using Microsoft.AspNetCore.Mvc;
using Models;
using Services;

namespace ControllersCar;

[ApiController]
[Route("api/[controller]/[action]")]
public class OrderController : ControllerBase
{
    OrderServices _orderService;
    public OrderController(OrderServices OrderService)
    {
        _orderService = OrderService;
    }

    [HttpGet]
    public List<Order> GetAll()
    {
        return _orderService.GetOrders();
    }

    [HttpGet("GetOrderById")]
    public Order GetOrderById(int id)
    {
        return _orderService.GetOrdeById(id);
    }

    [HttpPost("Add")]
    public void Add(Order newOrder)
    {
        _orderService.AddOrder(newOrder);
    }

    [HttpGet("Default")]
    public void Default(int id)
    {
        _orderService.Default();

    }

    [HttpGet("RemoveOrders")]
    public void RemoveOrders(int id)
    {
        _orderService.RemoveOrders(id);

    }

}