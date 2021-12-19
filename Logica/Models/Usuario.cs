
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Usuario : ICrudBase, IPersona  //Nota: Esto es de las interfaces
    {

        //Nota: Atributos de la interfaz IPersona
        public string Cedula { get ; set ; }
        public string Nombre { get ; set ; }
        public string Telefono { get ; set; }
        public string Email { get; set ; }
        public bool Activo { get; set ; }



        //Nota: Atributos de la interfaz ICrudBase
        public bool Agregar(int IdUsuarioP = 0)
        {
            bool R = false;

            //Paso 1.6.1 y 1.6.2
            Conexion MiCnnAdd = new Conexion();


            //Agregar los paremetros para el sp

            //Nota lista de paremetros
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@Cedula", this.Cedula));
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@Nombre", this.Nombre));
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@Telefono", this.Telefono));
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@Email", this.Email));
            //TODO:Encriptar contraseña
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@Contrasennia", this.Contrasennia));

            //Debemos enviar el valor del id del rol, usando la composicion de la clase UsuarioRol
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@IdRol", this.MiRol.IDUsuarioRol));

            //Paso 1.6.3 y  1.6.4
            int resultado = MiCnnAdd.DMLUpdateDeleteInsert("SPUsuarioAgregar");

            /*Activar el procedimiento almacenado*/

            Bitacora bitacora = new Bitacora(); //Es lo mismo en las otras acciones
            bitacora.GuardarAccionEnBitacora("Se ha Agregado un Usuario",IdUsuarioP);

            //Paso 1.6.5
            if (resultado > 0)
            {
                R = true;
            }

            return R;
        }

        public bool Editar(int IdUsuarioP = 0)
        {
            bool R = false;

            Conexion MiCnn = new Conexion();



            Bitacora bitacora = new Bitacora(); //Es lo mismo en las otras acciones
            bitacora.GuardarAccionEnBitacora("Se ha Agregado un Usuario", IdUsuarioP);

            return R;
        }

        public bool Eliminar(int IdUsuarioP = 0)
        {
            bool R = false;

            Bitacora bitacora = new Bitacora(); //Es lo mismo en las otras acciones
            bitacora.GuardarAccionEnBitacora("Se ha Agregado un Usuario", IdUsuarioP);

            return R;
        }

        //Adicionales
        public int IDUsuario { get; set; }
        public string CodigoRecuperacion { get; set; }
        public string Contrasennia { get; set; }

        //Composicion del rol de usuario

        public UsuarioRol MiRol { get; set; }

        //constructor
        public Usuario()
        {
            MiRol = new UsuarioRol();
        }


        //Funciones adicionales
        public bool Agregar(string cedula, string nombre, string telefono, string email, string contrasennia)
        {
            bool R = false;

            return R;
        }

         public Usuario ConsultarPorID(int ID)
        {
            Usuario R = new Usuario();

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@id", ID));

            DataTable DatosUsuario = new DataTable();

            DatosUsuario = MiCnn.DMLSelect("SPUsuarioConsultarPorID");

            if (DatosUsuario != null && DatosUsuario.Rows.Count == 1)
            {
                DataRow Fila = DatosUsuario.Rows[0];

                R.IDUsuario = ID;
                R.Nombre = Convert.ToString(Fila["Nombre"]);
                R.Cedula = Convert.ToString(Fila["Cedula"]);
                R.Telefono = Convert.ToString(Fila["Telefono"]);
                R.Email= Convert.ToString(Fila["Email"]);
                R.Contrasennia = Convert.ToString(Fila["Contrasennia"]);
                R.MiRol.IDUsuarioRol = Convert.ToInt32(Fila["IDUsuarioRol"]);



            }

           

            return R;


        }

        public bool ConsultarPorCedula(string cedula)
        {
            bool R = false;

            //Paso 1.3.1 y 1.3.2
            Conexion MiConexion = new Conexion();

            //En este caso y de forema didactica se decidio implementar un parametro para la cedula
            //este valor debe agregarse como parametro que debe llegar hasta el sp
            MiConexion.ListadoDeParametros.Add(new SqlParameter("@Cedula", cedula));

            //Paso 1.2.2 y 1.3.4
           DataTable retorno = MiConexion.DMLSelect("SPUsuarioConsultarPorCedula");

            //Paso 1.3.5

            if (retorno != null && retorno.Rows.Count > 0) //conteo de las filas es superior a 0, entonces retorne verdadero 
            {
                R = true;
            }
            return R;
        }

        public bool ConsultarPorEmail() //<-(sin p)
        {
            bool R = false;

            //Paso 1.4.1 y 1.4.2
            Conexion MiCnn = new Conexion();

            //Agregar al param,etro que debe llegar con el valor del email a consultar
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Email", this.Email)); //SP y recibe el paramtro

            //Paso 1.4.3 y 1.4.4
            DataTable resultado = MiCnn.DMLSelect("SPUsuarioConsultarPorEmail");

            //Paso 1.4.5
            if (resultado != null && resultado.Rows.Count > 0)
            {

            }

            return R;
        }
                      //Nota: tiene un parametro opcional ()
        public DataTable Listar(bool VerActivo = true)
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.DMLSelect("SPUsuariosListar");

            return R;
        }

        public bool EnviarCodigoRecuperacion()
        {
            bool R = false;

            return R;
        }

        public bool CambiarPassword(int iD, string nuevaContrasennia) //van en minusculas para que no afecte 
        {
            bool R = false;

            return R;
        }

        public bool Agregar()
        {
            throw new NotImplementedException();
        }
    }
}
