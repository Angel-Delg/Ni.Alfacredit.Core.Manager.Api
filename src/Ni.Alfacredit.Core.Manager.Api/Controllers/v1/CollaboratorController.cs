using Microsoft.AspNetCore.Mvc;

namespace Ni.Alfacredit.Core.Manager.Api.Controllers.v1
{
   public class CollaboratorController : ApiControllerBase 
   {
      [Tags("Collaborators")]
      [HttpGet("sucursales/{SUCURSAL_ID}/collaborators")]
      public async Task<IActionResult> GetAllCollaborators()
      {
         var results = await Mediator.Send(new {});
         return Ok(results);
      }

      [Tags("Collaborators")]
      [HttpGet("sucursales/{SUCURSAL_ID}/collaborators/{COLLABORATOR_ID}")]
      public async Task<IActionResult> GetCollaboratorById()
      {
         var results = await Mediator.Send(new {});
         return Ok(results);
      }

      [Tags("Collaborators")]
      [HttpPost("sucursales/{SUCURSAL_ID}/collaborators")]
      public async Task<IActionResult> CreateNewCollaborator()
      {
         var results = await Mediator.Send(new {});
         return Ok(results);
      }
   }  
}
