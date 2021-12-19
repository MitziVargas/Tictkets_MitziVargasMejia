using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class UsuarioRol : ICrudBase
    {

        public int IDUsuarioRol { get; set; }

        public string UsuarioRolDescripcion { get; set; }
        
        //Estas funciones deben cumplir con el contratoescrito en la interface ICrudBase
        //Nota:De la interfaz
        
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

        //Las siguientes funciones son las especificas de la clase que No estan en ICrudBase
        //osea no son comunes para mas de una clase


        bool ConsultarPorId()
        {

            bool R = false;

            return R;
        }

        bool ConsultarPorNombre()
        {

            bool R = false;

            return R;
        }

        public DataTable Listar()
        {
            DataTable R = new DataTable();

            //Secuencia SEQ: SDUsuarioRolListar //Paso 2.1 y 2.2

            Conexion MiConexion = new Conexion();

            //Paso 2.3
            R = MiConexion.DMLSelect("SPUsuarioRolListar");//Nota: Se deberia tener el sp antes de asignarlo en ""

            //Paso 2.4
            return R;
        }
    }
}
