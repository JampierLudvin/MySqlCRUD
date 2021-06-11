using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MySqlCRUD.CapaNegocio
{
    interface IAutor
    {


        DataTable ListarAutor();
        bool AgregarAutor(string codAutor, string Nombres, string Apellidos, string Nacionalidad);
        bool EliminarAutor(string CodAutor);
        bool ActualizarAutor(string codAutor, string Nombres, string Apellidos, string Nacionalidad);
        DataTable BuscarAutor(string texto);
    }


}
