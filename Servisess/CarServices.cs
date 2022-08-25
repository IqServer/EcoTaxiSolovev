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
<<<<<<< Updated upstream
       
=======

        Car newCar1 = new Car();
        newCar1.Free = false;
        newCar1.NumberCar = "E133EC";

        Car newCar2 = new Car();
        newCar2.Free = false;
        newCar2.NumberCar = "E223EC";

>>>>>>> Stashed changes
        _context.Cars.Add(newCar);
        _context.SaveChanges();
    }

    internal List<Car> Getcars()
    {
        throw new NotImplementedException();
    }

<<<<<<< Updated upstream
    internal List<Car> GetOperators()
    {
        throw new NotImplementedException();
    }

    internal Car GetOrderById(int id)
    {
        throw new NotImplementedException();
    }
=======

>>>>>>> Stashed changes

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

    public void RemoveCar(int id)
    {
        Car? Car = _context.Cars.FirstOrDefault(x => x.Id == id);
        _context.Cars.Remove(Car);
        _context.SaveChanges();
    }
}