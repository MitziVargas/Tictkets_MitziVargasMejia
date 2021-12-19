using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class TicketCategoria
    {

        //Atributos
        //prop

        public int IDTicketCategoria { get; set; }


        public string TicketCategoriaDescripcion { get; set; }

        //comportamientos


        public DataTable Listar()
        {
            DataTable R = new DataTable();

            //TODO:ESTO ES UN POR HACER(PENDIENTE)

            return R;

        }

    }
}
