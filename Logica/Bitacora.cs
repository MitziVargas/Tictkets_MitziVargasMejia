using Logica.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Bitacora
    {
        public Bitacora()
        {


        }
      

        public bool GuardarAccionEnBitacora(string Accion, int IDUsuario = 0)
        {
            bool Respuesta = false;

            Conexion MiConexion = new Conexion();
            
            MiConexion.ListadoDeParametros.Add(new SqlParameter("@IDUsuario",IDUsuario));
            MiConexion.ListadoDeParametros.Add(new SqlParameter("@Accion",Accion));

            int Ac =MiConexion.DMLUpdateDeleteInsert("SPGuardarAccionEnBitacora");
            if (Ac > 0)
            {
                Respuesta = true;
            }
            return Respuesta;/*eso es todo del store procedure*/


            //////////// NOTA:realizar el try para los errores y un if para el proceso
            ///

           if(string.IsNullOrEmpty())
            {

            }
     
            

           



        }
        
        

    }
}
