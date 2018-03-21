using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnEstagio.ObjetoTransferencia
{
    public class Usuario
    {
        public int IDUsuario { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }

        public Pessoa Pessoa { get; set; }

        public string GetChavePrimaria()
        {
            return this.IDUsuario.ToString();
        }
    }

    public class UsuarioCollection : List<Usuario> { }
}
