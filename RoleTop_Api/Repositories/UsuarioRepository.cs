using RoleTop_Api.Contexts;
using RoleTop_Api.Domains;
using RoleTop_Api.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoleTop_Api.Repositories
{
    public class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepository
    {
        RoleTopContext ctx = new RoleTopContext();
        public Usuario Login(string email_apelido, string senha)
        {
            return ctx.Usuario.FirstOrDefault(u => (u.Email == email_apelido) || (u.Apelido == email_apelido) && (u.Senha == senha));
        }
    }
}
