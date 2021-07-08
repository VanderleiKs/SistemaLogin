using SistemaLogin.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLogin.domain
{
    static class CadastroUsuario
    {
        private static int IdC = 0;
        public static List<Usuario> usuarios = new();

        public static Usuario UsuarioLogado { get; private set; }

        public static void AddUsuario(string nome, string email, string senha)
        {
            IdC++;
            usuarios.Add(new Usuario(IdC, nome, email, senha));
            
        }

        public static void ListUsuarios(List<Usuario> usuarios)
        {

        }

        public static bool Login(string usuario, string senha)
        {
            Usuario user = usuarios.FirstOrDefault(u => u.Email == usuario);
            if (user == null)
            {
                return false;
            }
            else if(user.Senha == senha)
            {
                UsuarioLogado = user;
                return true;
            }
            return false;
        }

        public static void Sair()
        {
            UsuarioLogado = null;
        }
    }
}
