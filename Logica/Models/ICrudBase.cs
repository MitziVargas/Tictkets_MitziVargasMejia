using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public interface ICrudBase
    {
        //Esta interfaz obliga a las clases que la implementen a cumplir el contrato de estructura aca escrito

        bool Agregar();
        bool Editar();
        bool Eliminar();


    }
}
