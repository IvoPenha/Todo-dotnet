namespace Todo.Domain.Entities;

public class User : Base
{
    public User()
    {
        
    }
    public string? Nome { get; set; }
    public string? Senha { get; set; }
    public string? Email { get; set; }
    
}