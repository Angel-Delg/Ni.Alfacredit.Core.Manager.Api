using FluentValidation;
using Ni.Alfacredit.Core.Manager.Api.Application.Users.Command.v1;

namespace Ni.Alfacredit.Core.Manager.Api.Application.Users.Validators.v1
{
   public class UpdatePasswordUserValidator : AbstractValidator<UpdatePasswordUserCommand>
   {
      public UpdatePasswordUserValidator()
      {
         RuleFor(Schema => Schema.CurrentPassword)
         .NotEmpty()
         .NotNull();

         RuleFor(Schema => Schema.NewPassword)
         .NotEmpty()
         .NotNull()
         .Matches(@"^(?=.*\d)(?=.*[@#./]).+$")
         .Matches(@"^(?=.*\d).+$");
         
         RuleFor(Schema => Schema.UserId)
         .NotEmpty()
         .NotNull();
      }
   }
}