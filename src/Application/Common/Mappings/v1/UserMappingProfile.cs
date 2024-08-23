using AutoMapper;
using Ni.Alfacredit.Core.Manager.Api.Application.Users.Command.v1;
using Ni.Alfacredit.Core.Manager.Api.Application.Users.Dto.v1;

namespace Ni.Alfacredit.Core.Manager.Api.Application.Common.Mappings.v1
{
   public class UserMappingProfile : Profile
   {
      public UserMappingProfile()
      {
         CreateMap<CreateUserCommand, CreateUserDto>()
         .ForMember(dto => dto.Username, src => src.MapFrom(output => output.Username));
      }
   }
}