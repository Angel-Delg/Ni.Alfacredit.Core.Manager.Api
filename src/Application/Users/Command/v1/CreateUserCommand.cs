using MediatR;
using System.ComponentModel.DataAnnotations;
using Ni.Alfacredit.Core.Manager.Api.Application.Users.Dto.v1;

namespace Ni.Alfacredit.Core.Manager.Api.Application.Users.Command.v1
{
   public class CreateUserCommand : IRequest<CreateUserDto>
   {  
      [Required]
      public required string Username { get; set; }

      [Required]
      public required string Colaborador { get; set; }

      [Required]
      public required string Password { get; set; }
   }  
}
