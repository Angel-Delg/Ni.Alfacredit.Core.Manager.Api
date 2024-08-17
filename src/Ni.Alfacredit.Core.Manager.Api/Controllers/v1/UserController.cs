using Microsoft.AspNetCore.Mvc;

namespace Ni.Alfacredit.Core.Manager.Api.Controllers.v1
{
   public class UserController : ApiControllerBase
   {

      [Tags("Users")]
      [HttpPost("authentication/users")]
      public async Task<IActionResult> CreateNewUser()
      {
         var results = await Mediator.Send(new {});
         return Ok(results);
      }

      [Tags("Users")]
      [HttpPatch("authentication/users/{USER_ID}")]
      public async Task<IActionResult> UpdatePasswordUser(
         [FromRoute] string USER_ID 
      )
      {
         var results = await Mediator.Send(new {});
         return Ok();
      }
   }
}