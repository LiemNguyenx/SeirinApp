using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Seirin.Application;
using Seirin.Application.Users.Commands;

namespace SeirinAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : BaseController
    {

        [HttpPost]
        public ActionResult<bool> Register(RegisterUser user)
        {
            var rs = Mediator.Send(user);
            return true;
        }
    }
}