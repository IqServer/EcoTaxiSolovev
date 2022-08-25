using Microsoft.AspNetCore.Mvc;
using Models;
using Services;

namespace ControllersOperator;

[ApiController]
[Route("api/[controller]/[action]")]
public class ControllerController : ControllerBase
{
    OperatorServices _operatorService;
    private object newOperator;

    public ControllerController(OperatorServices OperatorService)
    {
        _operatorService = OperatorService;
    }
    [HttpGet("Operator")]

    public List<Operator> GetAll()
    {
        return _operatorService.GetOperators();
    }

    [HttpGet("GetOrderById")]
    public Car GetOrderById(int id)
    {
        return _operatorService.GetOperatorById(id);
    }

    [HttpPost("Add")]
    public void Add([FromBody] Car newCar)
    {
        _operatorService.AddOperator(newOperator);
    }

    [HttpGet("Default")]
    public void Default(int id)
    {
        _operatorService.Default();

    }

    [HttpGet("RemoveOperators")]
    public void RemoveOperators(int id)
    {
        _operatorService.RemoveOperator(id);

    }

}
