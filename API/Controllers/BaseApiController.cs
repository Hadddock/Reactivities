using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;
using MediatR;
using Microsoft.Extensions.DependencyInjection; 

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] //controller is a placeholder that gets replaced with whatever the controller class name is
    public class BaseApiController : ControllerBase
    {
        private  IMediator _mediator;
        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices
            .GetService<IMediator>();
            
    }

    
}