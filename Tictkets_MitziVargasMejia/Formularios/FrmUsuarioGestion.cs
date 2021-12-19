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
    public partial class FrmUsuarioGestion : Form
    {
        //Este objeto sera el que se usa para asignar los avlores que se mostraran en 
        //el formulario ( La parte grafica )
        //deberia ontener toda la funcionalidad que se requiere para cumplir los requerimientos
        private Logica.Models.Usuario MiUsuarioLocal { get; set; }

        private DataTable ListaUsarios { get; set; }
        private DataTable ListaUsuariosConFiltro { get; set; }


        public FrmUsuarioGestion()
        {
            InitializeComponent();

            //Se instancia el objeto local
            // SDUsuarioRolListar Paso 1 y 1.1
            //Nota: Es el paso 1 del diagrma de secuencia -(Crear nueva instancia de Usuario) y devolviendo el susuariolocal
            MiUsuarioLocal = new Logica.Models.Usuario();

            ListaUsarios = new DataTable();
            ListaUsuariosConFiltro = new DataTable();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmUsuarioGestion_Load(object sender, EventArgs e)
        {
            //Este codigo se desencadena al form graficamente en pantalla
            //primero vamos a llenar la infromacion de los tipos de roles que existe en DD

            //Nota: Llamar el metodo

            cargarComboRoles();

            //Cargar la lista de usuarios
            LlenarListaUsuarios();

        }

        private void LlenarListaUsuarios()
        {
            ListaUsarios = MiUsuarioLocal.Listar();

            DgvListaUusarios.DataSource = ListaUsarios;
        }

        private void cargarComboRoles()
        {

            DataTable DatosDeRoles = new DataTable();

            // SDUsuarioRolListar Paso 2 
            DatosDeRoles = MiUsuarioLocal.MiRol.Listar();

            //Nota:Mostrar dos partes del combo box manual

            CbRol.ValueMember = "ID"; //alias el id
            CbRol.DisplayMember = "Descrip";

            //Paso 2.5
            CbRol.DataSource = DatosDeRoles;

            //Nota: Para que el usuario digite el dato

            CbRol.SelectedIndex = -1;

        }

        private bool ValidarDatosRequeridos()
            //Esta funcion valida los datos requeridos segun el modelo
            //logico y fisico de base de datos
        {
            bool R = false;

            if (!string.IsNullOrEmpty(MiUsuarioLocal.Nombre) &&
                !string.IsNullOrEmpty(MiUsuarioLocal.Cedula) &&
                !string.IsNullOrEmpty(MiUsuarioLocal.Email) &&
                !string.IsNullOrEmpty(MiUsuarioLocal.Contrasennia) &&
                MiUsuarioLocal.MiRol.IDUsuarioRol > 0
                )
            {
                //Si se cumplen los paremetros de validacion se pasa el valor de R a true
                R = true;
            }
            else
            {
                //Nota:Hacer mensaje se cumple o no
                //Trabajo en clase: Retroalimentar al usuario para indicar que campo hace falta digitar

                /* if (string.IsNullOrEmpty(MiUsuarioLocal.Nombre))

                  {
                     MessageBox.Show("Debe digitar en el espacio el *Nombre", ":(" , MessageBoxButtons.OK);
                  }
                  if (string.IsNullOrEmpty(MiUsuarioLocal.Cedula))
                  {
                      MessageBox.Show("Debe digitar en el espacio la *Cedula", ":(" , MessageBoxButtons.OK);
                  }
                  if(string.IsNullOrEmpty(MiUsuarioLocal.Email))
                  {
                      MessageBox.Show("Debe digitar en el espacio el *Email", ":(", MessageBoxButtons.OK);
                  }
                  if(string.IsNullOrEmpty(MiUsuarioLocal.Contrasennia))
                  {
                      MessageBox.Show("Debe digitar en el espacio la *Contraseña", ":(", MessageBoxButtons.OK);
                  }

                  
                  */

                //Nota:Realizado en clase

                if (string.IsNullOrEmpty(MiUsuarioLocal.Nombre))
                {
                    MessageBox.Show("Debe digitar el nombre", "Error de validacion", MessageBoxButtons.OK);
                    TxtNombre.Focus();
                    return false; //Nota: return R; es lo mismo
                }
                if (string.IsNullOrEmpty(MiUsuarioLocal.Cedula))
                {
                    MessageBox.Show("Debe digitar la Cedula", "Error de validacion", MessageBoxButtons.OK);
                    TxtCedula.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(MiUsuarioLocal.Email))
                {
                    MessageBox.Show("Debe digitar el Email", "Error de validacion", MessageBoxButtons.OK);
                    TxtEmail.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(MiUsuarioLocal.Contrasennia))
                {
                    MessageBox.Show("Debe digitar la Contraseña ", "Error de validacion", MessageBoxButtons.OK);
                    TxtNombre.Focus();
                    return false; 
                }
                if (MiUsuarioLocal.MiRol.IDUsuarioRol <= 0)
                {
                    MessageBox.Show("Debe seleccionar un Rol ", "Error de validacion", MessageBoxButtons.OK);
                    CbRol.Focus();
                    return false;
                }

            }
              

            return R;

        }

        private void LimpiarFormulario()
        {
           
            //Se procede a limpiar de datos los controles del formulario

            TxtIDUsuario.Clear();
            TxtNombre.Clear();
            TxtCedula.Clear();
            TxtTelefono.Clear();
            TxtEmail.Clear();
            TxtContrasennia.Clear();
            CbRol.SelectedIndex = -1;

            //Al reinstanciar el objeto local se eliminan todos los datos de los atributos
            MiUsuarioLocal = new Logica.Models.Usuario();


        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            //La asignacion de valores a atributos se realiza en tiempo real, usaremos
            //el evento Leave para alamacenar el datos del atributo al objeto global
            //MiUsuarioLocal.Cedula = TxtCedula.Text.Trim(); -> NO
            //MiUsuarioLocal.Email = TxtEmail.Text.Trim(); ->NO

            //Es importante validar que los atributos tengan datos antes de proceder

            if (ValidarDatosRequeridos())
            { 
            

            //Paso 1.3 y 1.3.6
                bool OKCedula = MiUsuarioLocal.ConsultarPorCedula(MiUsuarioLocal.Cedula);

                //Paso 1.4 y 1.4.6
                bool OKEmail = MiUsuarioLocal.ConsultarPorEmail();

                //Paso 1.5
                if (!OKCedula && !OKEmail) //Nota: ! es negativo o falso
                {
                    //Si no existe la cedula y sino existe el email tengo permiso para continuar con agregar

                    //Paso 1.6
                    
                    if (MiUsuarioLocal.Agregar(Commons.ObjetosGlobales.MiUsuarioDeSistema.IDUsuario))
                    {
                        MessageBox.Show("Usuario agregado correcatmente", ":)", MessageBoxButtons.OK);
                        //Nota: Mensaje ok

                        LimpiarFormulario();

                        LlenarListaUsuarios();

                        //Hecho//TODO:Se procede a limpiar el formulario y a agregar la lista de usuario en el datagridview

                    }
                    else
                    {     //NOTA: ME DA UN ERROR REVISAR, AGREGA Y SALE ESTE MENSAJE
                       MessageBox.Show("Ha ocurrido un error y no se ha guardado el usuario", ":(", MessageBoxButtons.OK);
                    }

                }
            }
        }

        private void TxtNombre_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtNombre.Text.Trim()))
            {
                MiUsuarioLocal.Nombre = TxtNombre.Text.Trim();
            }
            else
            {
                MiUsuarioLocal.Nombre = "";
            }
        }

        private void TxtCedula_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtCedula.Text.Trim()))
            {
                MiUsuarioLocal.Cedula = TxtCedula.Text.Trim();
            }
            else
            {
                MiUsuarioLocal.Cedula = "";
            }
        }

        private void TxtTelefono_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtTelefono.Text.Trim()))
            {
                MiUsuarioLocal.Telefono = TxtTelefono.Text.Trim();
            }
            else
            {
                MiUsuarioLocal.Telefono = "";
            }
        }

        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtEmail.Text.Trim()))
            {
                MiUsuarioLocal.Email = TxtEmail.Text.Trim();
            }
            else
            {
                MiUsuarioLocal.Email = "";
            }
        }

        private void TxtContrasennia_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtContrasennia.Text.Trim()))
            {
                MiUsuarioLocal.Contrasennia = TxtContrasennia.Text.Trim();
            }
            else
            {
                MiUsuarioLocal.Contrasennia = "";
            }
        }

        private void CbRol_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Nota:Cambio en el combo

            if (CbRol.SelectedIndex >= 0)
            {
                MiUsuarioLocal.MiRol.IDUsuarioRol = Convert.ToInt32(CbRol.SelectedValue);
            }
            else
            {
                MiUsuarioLocal.MiRol.IDUsuarioRol = 0;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void DgvListaUusarios_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvListaUusarios.SelectedRows.Count == 1)
            {
                LimpiarFormulario();

                //Nota:Obtener dato
                DataGridViewRow MiFila = DgvListaUusarios.SelectedRows[0];

                int CodigoUsuario = Convert.ToInt32(MiFila.Cells["CIDUsuario"].Value);

                MiUsuarioLocal = MiUsuarioLocal.ConsultarPorID(CodigoUsuario);

                TxtIDUsuario.Text = MiUsuarioLocal.IDUsuario.ToString();
                TxtNombre.Text = MiUsuarioLocal.Nombre;
                TxtCedula.Text = MiUsuarioLocal.Cedula;
                TxtCedula.Text = MiUsuarioLocal.Telefono;
                TxtCedula.Text = MiUsuarioLocal.Email;
                //TxtCedula.Text = MiUsuarioLocal.MiUsuarioLocal.Contrasennia;
                CbRol.SelectedValue = MiUsuarioLocal.MiRol.IDUsuarioRol;
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            //Segun el diagrama de casos de uso expandido, se denbe consultar por el
            //ID antes del proceso de actualizacion, esto deberia estar explicado en la secuencia correspondiente

            if (ValidarDatosRequeridos())
            {
                //Si se cumplen los datos minimos se procede

                //Uso un objeto temporal para no tocar el usuario local y poder evaluar
                //(si tiene datos en losatributos)n que el usuario existe aun en BD

                Logica.Models.Usuario ObjUsuario = MiUsuarioLocal.ConsultarPorID(MiUsuarioLocal.IDUsuario);

                if (ObjUsuario.IDUsuario > 0)
                {
                    //Si el id ( o cualquier atributo obligatorio tiene datos. se puede asegurar 
                    //que el formulario aun exista y proceder con el update 

                    if (MiUsuarioLocal.Editar())
                    {
                        //Se muestra mensaje de exito y se actualiza la lsita

                        MessageBox.Show("El usuario se ha actualizado correctamente", ":)", MessageBoxButtons.OK);

                        LimpiarFormulario();

                        LlenarListaUsuarios();
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error y no se actualizo el usuario", ":(", MessageBoxButtons.OK);
                    }
                }
            }
        }
    }
}
