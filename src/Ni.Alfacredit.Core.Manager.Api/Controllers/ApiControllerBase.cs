using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Ni.Alfacredit.Core.Manager.Api.Controllers
{
   [ApiController]
   [Route("api/v1")]
   public class ApiControllerBase : ControllerBase
   {
      private ISender _mediator = null;
      /// <summary>
      ///   Mediator Sender
      /// </summary>
      protected ISender Mediator => _mediator ??= HttpContext.RequestServices.GetService<ISender>();
   }
}