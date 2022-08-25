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
        newOperator.Mail = "Ashot228@mail.ru";
        newOperator.Name = "Ashot";
        newOperator.Post = "GOD";

        Operator newOperator1 = new Operator();
        newOperator1.Mail = "Stepan110@mail.ru";
        newOperator1.Name = "Stepan";
        newOperator1.Post = "Chiter";

        Operator newOperator2 = new Operator();
        newOperator2.Mail = "IlonMasckSpase@mail.ru";
        newOperator2.Name = "Ilon";
        newOperator2.Post = "MILIARDER";

        _context.Operators.Add(newOperator);
        _context.Operators.Add(newOperator1);
        _context.Operators.Add(newOperator2);
        _context.SaveChanges();
    }
    public Operator GetOpertorById(int id)
    {
        return _context.Operators.Where(x => x.Id == id).FirstOrDefault();
    }

    public void AddOperator(Operator newOperator)
    {
        _context.Operators.Add(newOperator);
        _context.SaveChanges();
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
