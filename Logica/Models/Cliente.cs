using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Cliente : ICrudBase, IPersona //Nota: las dos interfaces 
    {

        //Estos atributos vienen de IPersona //Nota: De la interfaz
        public string Cedula { get ; set; }
        public string Nombre { get ; set ; }
        public string Telefono { get ; set ; }
        public string Email { get ; set ; }
        public bool Activo { get ; set ; }

        //Estos atributos vienen de ICrudBasenota //Nota: De la interfaz
        public bool Agregar()
        {
            bool R = false;

            

            return R;
        }

        public bool Editar()
        {
            bool R = false;

            return R;
        }

        public bool Eliminar()
        {
            bool R = false;

            return R;
        }

        // Ahora se agregan los atributos que no estaban en las interfzaces 

        public int IDCliente { get; set; }
        public string Direccion { get; set; }
        public bool EnviarPromos { get; set; }

        //Se analiza si hay atributos compuestos y se agregan

        public ClienteCategoria  MiCategoria { get; set; } //Nota: algo que se programo
        public object MiBitacora { get; private set; }

        //Cuando tenemos atributos compuestos es necesario instanciarlo en el constructor de la clase
        public Cliente() //Nota:constructor de la clase con cto
        {
            MiCategoria = new ClienteCategoria();
        }

        //Ahora agregamos las funciones que no estan en interfaces

        bool ConsultarPorId(int ID)
        {
            bool R = false;

            return R;
        }

        bool ConsultarPorCedula(string Cedula)
        {
            bool R = false;

            return R;
        }

        public DataTable ListarActivo()
        {
            DataTable R = new DataTable();

            return R;
        }

        public DataTable ListarInactivos()
        {
            DataTable R = new DataTable();

            return R;
        }
        
    }
}
