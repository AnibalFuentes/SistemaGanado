using Datos;
using Entidad;
using System.Collections.Generic;

namespace Negocio
{
    public class N_Usuario
    {
        private D_Usuario D_Usuario = new D_Usuario();

        public List<Usuario> Listar()
        {
            return D_Usuario.ListarUsuarios();
        }

        public List<Usuario> Validar()
        {
            return D_Usuario.ValidarUsuarios();
        }

        public int Registrar(Usuario usuario, out string mensaje)
        {
            mensaje = string.Empty;
            if (usuario.Documento == "") { mensaje += "El documento no puede quedar vacío."; }
            if (usuario.NombreCompleto == "") { mensaje += "El nombre no puede quedar vacío."; }
            if (usuario.NombreUsuario == "") { mensaje += "El nombre de usuario no puede quedar vacío."; }
            if (usuario.TipoUsuario == "") { mensaje += "El tipo de usuario no puede quedar vacío."; }
            if (usuario.Contraseña == "") { mensaje += "La contraseña no puede quedar vacía."; }
            if (mensaje != string.Empty) { return 0; }
            else { return D_Usuario.RegistrarUsuario(usuario, out mensaje); }
        }

        public bool Editar(Usuario usuario, out string mensaje)
        {
            mensaje = string.Empty;
            if (usuario.Documento == "") { mensaje += "El documento no puede quedar vacío."; }
            if (usuario.NombreCompleto == "") { mensaje += "El nombre no puede quedar vacío."; }
            if (usuario.NombreUsuario == "") { mensaje += "El nombre de usuario no puede quedar vacío."; }
            if (usuario.TipoUsuario == "") { mensaje += "El tipo de usuario no puede quedar vacío."; }
            if (usuario.Contraseña == "") { mensaje += "La contraseña no puede quedar vacía."; }
            if (mensaje != string.Empty) { return false; }
            else { return D_Usuario.EditarUsuario(usuario, out mensaje); }

        }

        public bool Eliminar(Usuario usuario, out string mensaje)
        {
            return D_Usuario.EliminarUsuario(usuario, out mensaje);
        }
    }
}
