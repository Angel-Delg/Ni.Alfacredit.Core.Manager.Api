using MediatR;

namespace Ni.Alfacredit.Core.Manager.Api.Application.Users.Command.v1
{
   public class UpdatePasswordUserCommand : IRequest 
   {
      public Guid UserId { get; set; }
      public string? CurrentPassword { get; set; }
      public string? NewPassword { get; set; }  
   }
}