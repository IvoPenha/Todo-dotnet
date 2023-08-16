namespace Todo.Domain.Entities;

public class Base
{

    public Base()
    {
        
    }

    public Base(List<string> validate, long id)
    {
        Validate = validate;
        Id = id;
    }

    public long Id { get; set; }

    public List<string> Validate;

    public Base(List<string> validate)
    {
        Validate = validate;
    }
}