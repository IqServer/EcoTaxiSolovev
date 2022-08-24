using Freebob;
using Models;

namespace Services;

public class RequestServices
{
    readonly DataContext _context;

    public RequestServices(DataContext context)
    {
        _context = context;

    }
    public void Default()
    {
        Request newRequest = new Request();
        newRequest.Address = "Mamino 67";
        newRequest.Lat = 23.0023989f;
        newRequest.Lot = 98.9389278f;
        newRequest.Prod = "Plastic";
        newRequest.User = "Dima";
        newRequest.weight = 23.09f;

        Request newRequest1 = new Request();
        newRequest.Address = "Mamino 6";
        newRequest.Lat = 23.0023989f;
        newRequest.Lot = 98.9389278f;
        newRequest.Prod = "galss";
        newRequest.User = "Sasha";
        newRequest.weight = 23.09f;

        Request newRequest2 = new Request();
        newRequest.Address = "Mamino 7";
        newRequest.Lat = 23.0023989f;
        newRequest.Lot = 98.9389278f;
        newRequest.Prod = "Paper";
        newRequest.User = "Oleg";
        newRequest.weight = 23.09f;

         _context.Requests.Add(newRequest);
        _context.Requests.Add(newRequest1);
        _context.Requests.Add(newRequest2);
        _context.SaveChanges();
    }
    public Request GetRequestById(int id)
    {
        return _context.Requests.Where(x => x.Id == id).FirstOrDefault();
    }

    public void AddRequest(Request newRequest)
    {

    }
    public List<Request> GetRequest()
    {
        return _context.Requests.ToList();
    }
}