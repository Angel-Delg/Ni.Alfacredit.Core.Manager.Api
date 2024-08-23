using Microsoft.AspNetCore.Mvc;
using Ni.Alfacredit.Core.Manager.Api.Application.Users.Command.v1;

namespace Ni.Alfacredit.Core.Manager.Api.Controllers.v1
{
   /// <summary>
   ///  User Controller for all case of users
   /// </summary>
   public class UserController : ApiControllerBase
   {

      /// <summary>
      ///  Create user controller for creation of users to access
      /// </summary>
      /// <param name="BODY"></param>
      /// <returns></returns>
      [Tags("Users")]
      [HttpPost("authentication/users")]
      public async Task<IActionResult> CreateUserControllerAsync(
         [FromBody] CreateUserCommand BODY
      )
      {
         var results = await Mediator.Send(BODY);
         return Ok(results);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="USER_ID"></param>
      /// <param name="BODY"></param>
      /// <returns></returns>
      [Tags("Users")]
      [HttpPatch("authentication/users/{USER_ID}")]
      public async Task<IActionResult> UpdatePasswordUserControllerAsync(
         [FromRoute] string USER_ID,
         [FromBody] UpdatePasswordUserCommand BODY
      )
      {
         await Task.Delay(100);
         return Ok();
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="USER_ID"></param>
      /// <returns></returns>
      [Tags("Users")]
      [HttpDelete("authentication/users/{USER_ID}")]
      public async Task<IActionResult> DisableUserControllerAsync(
         [FromRoute] string USER_ID
      )
      {
         await Task.Delay(100);
         return Ok();
      }
   }
}