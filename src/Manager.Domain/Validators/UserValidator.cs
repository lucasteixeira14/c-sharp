using FluentValidation;
using Manager.Domain.Entities;

namespace Manager.Domain.Validators
{


 public class UserValidator : AbstractValidator<User>
 {
  public UserValidator()
  {
   RuleFor(x => x).NotEmpty().WithMessage("A entidade não pode ser vazia")
   .NotNull()
  .WithMessage("A entidade não pode ser nula");

   RuleFor(x => x.Name).NotNull().WithMessage("A entidade não pode ser nula")
   .MinimumLength(5).WithMessage("O valor deve conter no mínimo 3 caracteres");


  }

 }


}
