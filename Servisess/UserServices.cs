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
        newUser.Address = "Mamino 67";
        newUser.Name = "Mark";
        newUser.Surname = "Petrov";
        newUser.PhoneNumber = +8959872243f;
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
