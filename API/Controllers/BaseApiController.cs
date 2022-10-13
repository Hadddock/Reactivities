using Microsoft.AspNetCore.Mvc;
using MediatR;
using Application.Core;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] //controller is a placeholder that gets replaced with whatever the controller class name is
    public class BaseApiController : ControllerBase
    {
        private  IMediator _mediator;
        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices
            .GetService<IMediator>();

        protected ActionResult HandleResult<T>(Result<T> result)
        {
            if(result == null) return NotFound();
            if (result.IsSuccess && result.Value != null)
                return Ok(result.Value);
            if (result.IsSuccess && result.Value == null)
                return NotFound();
            return BadRequest(result.Error);
        } 

         protected ActionResult HandlePagedResult<T>(Result<PagedList<T>> result)
        {
            if(result == null) return NotFound();
            if (result.IsSuccess && result.Value != null)
            {
                Response.AddPaginationHeader(result.Value.CurrentPage, result.Value.PageSize,
                    result.Value.TotalCount, result.Value.TotalPages);
                return Ok(result.Value);
            }
                
            if (result.IsSuccess && result.Value == null)
                return NotFound();
            return BadRequest(result.Error);
        }    
    }

    
}