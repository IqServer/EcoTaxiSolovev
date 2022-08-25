namespace Models;

public class Point
{
    public int Id { get; set; }
    public float? Lat { get; set; }
    public float? Lon { get; set; }
    public string? Title { get; set; }
    public string? Address { get; set; }
    public Request? Request { get; set; }
    public int? RequestId { get; set; }
    public float? PhoneNumber { get; set; }
    public string? time { get; set; }

    public List<string>? Fractions {get;set;}
}