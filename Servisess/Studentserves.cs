using Freebob;
using Models;

namespace Services;

public class StudentServices
{
    readonly DataContext _context;

    public StudentServices(DataContext context )
    {
     _context = context;

    //  List<Place> GetStudents()
    //  {
    //           var places =  _context.Places.ToList();
    //           return places;
    //  }
    }
    public void Default()
    {
     

     Operator newOperator =new Operator();
     newOperator.Mail = "BRAWL@mail.ru";
     newOperator.Name = "Ashot";
     newOperator.Post = "GOD";

     Order newOrder = new Order();
     newOrder.Operator = "Gena";
     newOrder.Request = "";
     newOrder.Time = (new TimeOnly(23, 45));

     Point newPoint = new Point();
     newPoint.Lat = 23.4544343434f;
     newPoint.Lon = 43.2138712392f;
     newPoint.Title = "recycling center";
     newPoint.Address = "Mamino 67";
    
     Request newRequest = new Request();
     newRequest.Address = "Mamino 67";
     newRequest.Lat = 23.0023989f;
     newRequest.Lot = 98.9389278f;
     newRequest.Prod = "galss";
     newRequest.User = "";
     newRequest.weight = 23.09f;
      
    User newUser = new User();
    newUser.Address ="Mamino 67";
    newUser.Name = "Mark";
    newUser.Surname = "Petrov";
    newUser.PhoneNumber = +8959872243f;

    _context.Orders.Add(newOrder);
    _context.Requests.Add(newRequest);
    _context.Users.Add(newUser);
    _context.Points.Add(newPoint);
    _context.Operators.Add(newOperator);

    _context.SaveChanges();
           }
    }
