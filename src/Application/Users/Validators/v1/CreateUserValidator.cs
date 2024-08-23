using FluentValidation;
using Ni.Alfacredit.Core.Manager.Api.Application.Users.Command.v1;

namespace Ni.Alfacredit.Core.Manager.Api.Application.Users.Validators.v1
{
   public class CreateUserValidator : AbstractValidator<CreateUserCommand>
   {
      public CreateUserValidator()
      {
         RuleFor(Schema => Schema.Password)
         .MinimumLength(8)
         .NotEmpty()
         .NotNull()
         .Matches(@"^(?=.*\d)(?=.*[@#./]).+$")
         .Matches(@"^(?=.*\d).+$");
         
         RuleFor(Schema => Schema.Username)
         .NotEmpty()
         .NotNull()
         .MinimumLength(5);

         RuleFor(Schema => Schema.Colaborador)
         .NotEmpty()
         .NotNull();
      }
   }
}