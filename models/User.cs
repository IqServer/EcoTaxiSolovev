namespace Models;

public class User
{
    public int Id { get; set; }
    public string? Address { get; set; }
    public float? PhoneNumber { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public Point? Point { get; set; }
    public int? PointId { get; set; }
}
