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
    public Operator GetOrderById(int id)
    {
        return _operatorService.GetOpertorById(id);
    }

    [HttpPost("Add")]
    public void Add([FromBody] Operator newOperator)
    {
        _operatorService.AddOperator(newOperator);
    }

    [HttpGet("Default")]
    public void Default(int id)
    {
        _operatorService.Default();

    }

}
