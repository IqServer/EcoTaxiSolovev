using Microsoft.AspNetCore.Mvc;
using Models;
using Services;

namespace ControllersCar;

[ApiController]
[Route("api/[controller]/[action]")]
public class CarController : ControllerBase
{
    CarServices _carService;
    public CarController(CarServices carService)
    {
        _carService = carService;
    }
    [HttpGet("Car")]

    public List<Car> GetAll()
    {

         return _carService.GetCars();
    }
  
    [HttpGet("GetCarById")]
    public Car GetCarById(int id)
    {
        return _carService.GetCarById(id);
    }

    [HttpPost("Add")]
    public void Add([FromBody] Car newCar)
    {
        _carService.AddCar(newCar);
    }

    [HttpGet("Default")]
    public  void Default(int id)
    {
     _carService.Default();

    }
    
    [HttpGet("RemoveCars")]
    public void RemoveOperators(int id)
    {
        _carService.RemoveCar(id);

    }

}






