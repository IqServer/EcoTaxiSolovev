namespace Models;

public class Order
{
    public int Id { get; set; }
    public string? Operator { get; set; }
    public TimeOnly? Time { get; set; }
    public string? Request { get; set; }
    public string? Address { get; set; }
}