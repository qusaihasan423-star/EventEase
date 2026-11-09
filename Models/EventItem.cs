namespace EventManagement.Models;

public sealed class EventItem
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Date { get; set; } = "";
    public string Location { get; set; } = "";
}
