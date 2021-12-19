using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tictkets_MitziVargasMejia.Commons
{
    public static class ObjetosGlobales
    {

        //Formularios de uso recurrente en el sistema
        //Si en el formulario deberia verse solo una vez por sesion lo mas conveniente
        //es definirlo de forma estatica y no dinamica

        public static Form MiFormPrincipal = new Formularios.FrmMain();

        public static Formularios.FrmUsuarioGestion FormularioGestionDeUsuarios = new Formularios.FrmUsuarioGestion();

       

        //EXAMEN: Objeto global de Bitacora

        public static Bitacora MiBitacora = new Bitacora();


        //Se definen los objetos( basados en clases) deben ser accesibles desde cualquier lugar de la app
        public static Logica.Models.Usuario MiUsuarioDeSistema = new Logica.Models.Usuario();

    }
}
