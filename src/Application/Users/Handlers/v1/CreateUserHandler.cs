using MediatR;
using AutoMapper;
using Ni.Alfacredit.Core.Manager.Api.Application.Users.Command.v1;
using Ni.Alfacredit.Core.Manager.Api.Application.Users.Dto.v1;

namespace Ni.Alfacredit.Core.Manager.Api.Application.Users.Handlers.v1
{
   public class CreateUserHandler : IRequestHandler<CreateUserCommand, CreateUserDto>
   {
      private readonly IMapper _mapper;
      public CreateUserHandler(IMapper mapper)
      {
         _mapper = mapper;
      }

      public async Task<CreateUserDto> Handle(CreateUserCommand request, CancellationToken cancellationToken)
      {
         await Task.Delay(100);
         return _mapper.Map<CreateUserDto>(request);
      }
   }
}
