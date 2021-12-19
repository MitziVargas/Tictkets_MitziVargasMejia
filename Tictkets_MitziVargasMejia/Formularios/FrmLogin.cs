using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tictkets_MitziVargasMejia.Formularios
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            //Salimos de la aplicacion, cuando se le da clik

            Application.Exit();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            TxtPassword.UseSystemPasswordChar = false;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            TxtPassword.UseSystemPasswordChar = true;
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            //TODO: Hay que validar que el usuario y la Contraseña sean
            //correctas antes de mostrar el Frm Principal
            Commons.ObjetosGlobales.MiUsuarioDeSistema.IDUsuario = 1;
            Commons.ObjetosGlobales.MiUsuarioDeSistema.Nombre = "Mitzi";
            Commons.ObjetosGlobales.MiUsuarioDeSistema.MiRol.IDUsuarioRol = 1;
            Commons.ObjetosGlobales.MiUsuarioDeSistema.Telefono = "alguno";

            //Muestro el objeto global del FrmMain
            Commons.ObjetosGlobales.MiFormPrincipal.Show();

            //Oculto (No destruyo) el frm Login
            this.Hide();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
