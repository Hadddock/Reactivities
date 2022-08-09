using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] //controller is a placeholder that gets replaced with whatever the controller class name is
    public class BaseApiController : ControllerBase
    {
        
    }
}