using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaBD.Negocio
{
    public class DUsuarios
    {
        public string NombreUsuario { get; set; }
        public string Password { get; set; }
        public string TipoUsuario { get; set; }
        public int EstadoUsuario { get; set; }

        public DUsuarios() { }
        public DUsuarios(string nombreUsuario, string passwordUsuario, string tipoUsuario, int estadoUsuario) {
            this.NombreUsuario = nombreUsuario;
            this.Password = passwordUsuario;
            this.TipoUsuario = tipoUsuario;
            this.EstadoUsuario = estadoUsuario;
        }


    }
}
