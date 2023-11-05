using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menuPrincipal.Interfaces
{
    internal interface InterfaceCRUD 
    {
        bool Agregar(object Objeto);

        DataTable Consulta(string tabla);

        bool Elimnar(object Objeto);

        bool Modificar(object Objeto);

    }
}
