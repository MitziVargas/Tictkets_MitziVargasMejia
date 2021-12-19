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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void TmrHora_Tick(object sender, EventArgs e)
        {
            LblHora.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //Nota:Cuando se muestra este se activa el timer

            TmrHora.Enabled = true;
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //TODO: Analizar si queremos hacer un logout cuando cerramos el principal

            Application.Exit(); //  Nota: Se cierra total el fr, sin el boton rojo
        }

        private void gestiónDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Mostramos el formulario global de gestion de usuarios

            Commons.ObjetosGlobales.FormularioGestionDeUsuarios.Show();
        }
    }
}
