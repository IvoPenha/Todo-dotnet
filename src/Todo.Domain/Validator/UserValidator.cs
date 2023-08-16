using FluentValidation;
using Todo.Domain.Entities;

namespace Todo.Domain.Validator;

public class UserValidator : AbstractValidator<User>
{
    public UserValidator()
    {
        RuleFor(u => u.Senha)
            .NotEmpty()
            .NotNull()
            .MinimumLength(4)
            .MaximumLength(25);
        RuleFor(u => u.Email)
            .NotEmpty()
            .NotNull()
            .MinimumLength(4)
            .MaximumLength(25);
        RuleFor(u => u.Nome)
            .NotEmpty()
            .NotNull()
            .MinimumLength(4)
            .MaximumLength(25);
    }
}