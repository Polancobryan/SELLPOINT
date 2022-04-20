using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Datos;

namespace Capa_Negocios
{
    public class acciones
    {
        private Metodos data = new Metodos();

        public DataTable consultar()
        {
            DataTable tabla = new DataTable();
            tabla = data.consultar();
            return tabla;
        }

        public void Eliminar(string id_Entidad)
        {
            data.Eliminar(Convert.ToInt32(id_Entidad));
        }

        //------------------------------------------Metodos de GruposEntidades
        public DataTable gpConsultar()
        {
            DataTable tabla = new DataTable();
            tabla = data.gpConsultar();
            return tabla;
        }

        public void gpEliminar(string idGrupoEntidad)
        {
            data.gpEliminar(Convert.ToInt32(idGrupoEntidad));
        }

        //------------------------------------------Metodos de TiposEntidades
        public DataTable tpConsultar()
        {
            DataTable tabla = new DataTable();
            tabla = data.tpConsultar();
            return tabla;
        }

        public void tpEliminar(string IdTipoEntidad)
        {
            data.tpEliminar(Convert.ToInt32(IdTipoEntidad));
        }
    }
}
