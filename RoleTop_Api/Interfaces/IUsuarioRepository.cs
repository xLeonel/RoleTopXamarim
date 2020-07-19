using RoleTop_Api.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoleTop_Api.Interfaces
{
    public interface IUsuarioRepository : IRepositoryBase<Usuario>
    {
        Usuario Login(string email_apelido, string senha);
    }
}
