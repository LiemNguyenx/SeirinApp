using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace Seirin.Application.Users.Commands
{
    public class RegisterUser : IRequest<bool>
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
