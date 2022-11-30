using Datos;
using Entidad;
using System.Collections.Generic;

namespace Negocio
{
    public class N_Ganado
    {
        D_Ganado datosGanado = new D_Ganado();

        public List<Ganado> Listar()
        {
            return datosGanado.ListarGanados();
        }
        public int Registrar(Ganado Ganado, out string mensaje)
        {
            return datosGanado.RegistrarGanado(Ganado, out mensaje);
        }
        public bool Editar(Ganado Ganado, out string mensaje)
        {
            return datosGanado.EditarGanado(Ganado, out mensaje);
        }
        public bool Eliminar(Ganado Ganado, out string mensaje)
        {
            return datosGanado.EliminarGanado(Ganado, out mensaje);
        }
    }
}

