using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Seirin.Persistence;

namespace Seirin.Application.Users.Commands
{
    
    public class RegisterUserHandle : IRequestHandler<RegisterUser, bool>
    {
        private readonly DbContextSeirin _context;
        
        public RegisterUserHandle(DbContextSeirin context)
        {
            _context = context;
        }
        public async Task<bool> Handle(RegisterUser request, CancellationToken cancellationToken)
        {
            _context.Mst_Users.Add(new Domain.Entities.mst_user {
                mail = request.Email,
                login_pass = request.Password,
                name = request.Name
                
            });
            int rs = await _context.SaveChangesAsync();
            bool rs1 = rs == 1 ? true : false;
            return  rs1;
            //throw new NotImplementedException();
        }
    }
}
