namespace noteAPI.Model;

public class User
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
    public string UserName { get; set; } = string.Empty;
    public DateTime CreateDate { get; set; }
}
