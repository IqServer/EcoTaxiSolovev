using Freebob;
using Models;

namespace Services;

public class OrderServices
{
    readonly DataContext _context;

    public OrderServices(DataContext context)
    {
        _context = context;


    }
    public void Default()
    {
        Order newOrder = new Order();
        newOrder.Operator = "Gena";
        newOrder.Request = "";
        newOrder.Time = (new TimeOnly(23, 15));
        newOrder.Address = "Mamino 67";

        Order newOrder1 = new Order();
        newOrder.Operator = "Artur";
        newOrder.Request = "";
        newOrder.Time = (new TimeOnly(23, 23));
        newOrder.Address = "Mamino 6";

        Order newOrder2 = new Order();
        newOrder.Operator = "Dima";
        newOrder.Request = "";
        newOrder.Time = (new TimeOnly(23, 09));
        newOrder.Address = "Mamino 7";



        _context.Orders.Add(newOrder);
        _context.Orders.Add(newOrder1);
        _context.Orders.Add(newOrder2);
        _context.SaveChanges();
    }
    public Order GetOrdeById(int id)
    {
        return _context.Orders.Where(x => x.Id == id).FirstOrDefault();
    }
    public void AddOrder(Order newOrder)
    {
        _context.Orders.Add(newOrder);
        _context.SaveChanges();
    }
    public List<Order> GetOrders()
    {
        return _context.Orders.ToList();
    }

}