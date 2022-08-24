namespace Models;

public class Operator
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Mail { get; set; }
    public string? Post { get; set; }
    public User? User { get; set; }
    public int? UserId { get; set; }
    public Car? Car { get; set; }
    public int? CarId { get; set; }
}