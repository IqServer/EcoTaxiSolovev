using Freebob;
using Models;

namespace Services;

public class CarServices
{
    readonly DataContext _context;

    public CarServices(DataContext context)
    {
        _context = context;


    }
    public void Default()
    {
        Car newCar = new Car();
        newCar.Free = false;
        newCar.NumberCar = "E123EC";
       
        _context.Cars.Add(newCar);
        _context.SaveChanges();
    }

    internal List<Car> Getcars()
    {
        throw new NotImplementedException();
    }

    internal List<Car> GetOperators()
    {
        throw new NotImplementedException();
    }

    internal Car GetOrderById(int id)
    {
        throw new NotImplementedException();
    }

    public Car GetCarById(int id)
    {
        return _context.Cars.Where(x => x.Id == id).FirstOrDefault();
    }

    public void AddCar(Car newCar)
    {

        _context.Cars.Add(newCar);
        _context.SaveChanges();

    }

    public List<Car> GetCars()
    {
        return _context.Cars.ToList();
    }
}