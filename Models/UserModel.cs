namespace TicketingAPI.Models;

public class UserModel
{
    public long Id { get; set; }
    public string? Username { get; set; }
    public string? Password { get; set; }
    public bool IsComplete { get; set; }
}