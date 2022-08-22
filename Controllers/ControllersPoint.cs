using Microsoft.AspNetCore.Mvc;
using Models;
using Services;

namespace ControllersPoint;

[ApiController]
[Route("api/[controller]/[action]")]
public class PointController : ControllerBase 
{
    PointServices _pointService;
    public PointController(PointServices pointService)
    {
        _pointService = pointService;
    }
    [HttpGet("Point")]

    public List<Point> GetAll()
    {

         return _pointService.GetPoints();
    }
  
    [HttpGet("GetPointById")]
    public Point GetPointById(int id)
    {
        return _pointService.GetCarById(id);
    }

    [HttpPost("Add")]
    public void Add([FromBody] Point newPoint)
    {
        _pointService.AddPoint(newPoint);
    }

    [HttpGet("Default")]
    public  void Default(int id)
    {
     _pointService.Default();

    }

}