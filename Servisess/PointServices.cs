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
        newPoint.Lon = 43.2138712392f;
        newPoint.Title = "recycling center";
        newPoint.Address = "Mamino 67";

        _context.Points.Add(newPoint);
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
