using Freebob;
using Models;

namespace Services;

public class OperatorServices
{
    readonly DataContext _context;

    public OperatorServices(DataContext context)
    {
        _context = context;
    }
    public void Default()
    {
        Operator newOperator = new Operator();
        newOperator.Mail = "BRAWL@mail.ru";
        newOperator.Name = "Ashot";
        newOperator.Post = "GOD";

        _context.Operators.Add(newOperator);
        _context.SaveChanges();
    }
    public Operator GetCarById(int id)
    {
        return _context.Operators.Where(x => x.Id == id).FirstOrDefault();
    }

<<<<<<< Updated upstream
    internal Car GetOperatorById(int id)
    {
        throw new NotImplementedException();
    }

=======
>>>>>>> Stashed changes
    public void AddOperator(Operator newOperator)
    {
        _context.Operators.Add(newOperator);
        _context.SaveChanges();
    }

    internal void AddOperator(object newOperator)
    {
        throw new NotImplementedException();
    }

    public List<Operator> GetOperators()
    {
        return _context.Operators.ToList();
    }
       
    public void RemoveOperator(int id)
    {
        Operator? Operator = _context.Operators.FirstOrDefault(x => x.Id == id);
        _context.Operators.Remove(Operator);
        _context.SaveChanges();
    }

}
