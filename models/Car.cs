namespace Models;

public class Car
{
    public string? NumberCar { get; set; }
    public int Id { get; set; }
    public bool? Free { get; set; }
    public Request? Request { get; set; }
    public int? RequestId { get; set; }
}