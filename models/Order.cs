namespace Models;

public class Order
{
    public int Id { get; set; }
    public string? Operator { get; set; }
    public string? Address { get; set; }
    public string? Fio { get; set; }
    public float mass { get; set; }
    public string? product { get; set; }
    public DateTime time { get; set; }
    public string? status { get; set; }
    

}