using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace MySqlCRUD.CapaNegocio
{
    interface IPrestamo
    {
        DataTable ListarPrestamo();
        bool AgregarPrestamo(string FechaPrestamo, string CodAutor, string CodLibro);
        bool EliminarPrestamo(string FechaPrestamo, string CodLibro, string CodAutor);
        bool ActualizarPrestamo(string FechaPrestamo, string CodLibro, string CodAutor);
        DataTable BuscarPrestamo(string texto);
    }
}
