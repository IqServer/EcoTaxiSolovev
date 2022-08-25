using Freebob;
using Models;

namespace Services;

public class UserServices
{
    readonly DataContext _context;

    public UserServices(DataContext context)
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
        User newUser = new User();
        newUser.Address = "Opera 67";
        newUser.Name = "Mark";
        newUser.Surname = "Petrov";
        newUser.PhoneNumber = +798097277766;

        User newUser1 = new User();
        newUser1.Address = "Opera 7";
        newUser1.Name = "Gena";
        newUser1.Surname = "Petrov";
        newUser1.PhoneNumber = +89439089980;

        User newUser2 = new User();
        newUser2.Address = "Opera 6";
        newUser2.Name = "Dima";
        newUser2.Surname = "Petrov";
        newUser2.PhoneNumber = +79509727755;

        _context.Users.Add(newUser);
        _context.Users.Add(newUser1);
        _context.Users.Add(newUser2);

        _context.SaveChanges();
    }

    public User GetUserById(int id)
    {
        return _context.Users.Where(x => x.Id == id).FirstOrDefault();
    }
    public void AddUser(User newUser)
    {

        _context.Users.Add(newUser);
        _context.SaveChanges();
    }
    public List<User> GetUser()
    {
        return _context.Users.ToList();
    }

    public void RemoveUser(int id)
    {
        User? User = _context.Users.FirstOrDefault(x => x.Id == id);
        _context.Users.Remove(User);
        _context.SaveChanges();
    }
}
