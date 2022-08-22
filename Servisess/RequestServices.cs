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
        newRequest.Prod = "galss";
        newRequest.User = "";
        newRequest.weight = 23.09f;
    }
    public Request GetRequestById(int id)
    {
        return _context.Requests.Where(x => x.Id == id).FirstOrDefault();
    }

    public void AddRequest(Request newRequest)
    {
       
         _context.Requests.Add(newRequest);
        _context.SaveChanges();
    }
     public List<Request> GetRequest()
     {
         return _context.Requests.ToList();
     }
}