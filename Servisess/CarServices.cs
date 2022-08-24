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

         Car newCar1 = new Car();
        newCar1.Free = false;
        newCar1.NumberCar = "E133EC";

         Car newCar2 = new Car();
        newCar2.Free = false;
        newCar2.NumberCar = "E223EC";
       
        _context.Cars.Add(newCar);
        _context.Cars.Add(newCar1);
        _context.Cars.Add(newCar2);
        _context.SaveChanges();
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