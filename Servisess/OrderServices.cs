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
        newOrder.Time = (new TimeOnly(23, 45));

        _context.Orders.Add(newOrder);
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
<<<<<<< Updated upstream
=======
    public void RemoveOrders(int id)
    {
        Order? Orders = _context.Orders.FirstOrDefault(x => x.Id == id);
        _context.Orders.Remove(Orders);
        _context.SaveChanges();
    }

>>>>>>> Stashed changes
}