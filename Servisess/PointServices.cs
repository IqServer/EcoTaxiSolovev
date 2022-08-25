using Freebob;
using Models;

namespace Services;

public class PointServices
{
    readonly DataContext _context;

    public PointServices(DataContext context)
    {
        _context = context;


    }
    public void Default()

    {
        Point newPoint = new Point();
        newPoint.Lat = 23.4544343434f;
        newPoint.Lon = 43.3392498329f;
        newPoint.Title = "recycling center";
        newPoint.Address = "Mamino 67";

        Point newPoint1 = new Point();
        newPoint1.Lat = 23.3829834287f;
        newPoint1.Lon = 41.2138712392f;
        newPoint1.Title = "recycling center";
        newPoint1.Address = "Mamino 6";

        Point newPoint2 = new Point();
        newPoint2.Lat = 98.2122143434f;
        newPoint2.Lon = 43.2138712392f;
        newPoint2.Title = "recycling center";
        newPoint2.Address = "Mamino 7";


        _context.Points.Add(newPoint);
        _context.Points.Add(newPoint1);
        _context.Points.Add(newPoint2);
        _context.SaveChanges();
    }
    public Point GetCarById(int id)
    {
        return _context.Points.Where(x => x.Id == id).FirstOrDefault();
    }
    public void AddPoint(Point newPoint)
    {

        _context.Points.Add(newPoint);
        _context.SaveChanges();
    }
    public List<Point> GetPoints()
    {
        return _context.Points.ToList();
    }
}
