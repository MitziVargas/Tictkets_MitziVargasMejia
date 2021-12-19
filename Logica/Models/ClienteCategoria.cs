using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class ClienteCategoria
    {
        //Hay varias de usar los atributos de una clase, esta es autoimplementacion

        //Nota: Autoimplementacion, primer atributo en mayuscula I es la funcion que asigna
        //el valor a ese atributo
        //Esta funcion IDClienteCategoria, no es el nombre o valor del atributo, es el nombre
        //de la funcion que asigna o que extrae valores a ese atributo
        //Se realiza con prop
        //Forma 1 de realizarlo
        public int IDClienteCategoria{ get; set; } //Puede modificar al que se necessite

        //Forma 2 de realizarlo
        //Nota: Otra forma de ver un atributo
        //Esta otra forma es la "normal" muy usada por ejemplo en java


        private string clienteCategoriaDescripcion; //Atibuto privado y comienza en minuscula

        //Nota: Esta funcion MyProperty que permite extraer y
        //asignar un valor al atributo privado private string clienteCategoriaDescripcion;
        //Se realiza con propfull

        public string ClienteCategoriaDescripcion //funcion publica se llaman igual solo que esta comienza en Mayuscula
        {
            get { return clienteCategoriaDescripcion ; }
            set { ClienteCategoriaDescripcion = value; }
        }


        //Luego de escribir los atributos, seguimos con las funciones y metodos


       public DataTable Listar()
        {
            DataTable R = new DataTable();

            //Aca va la funcionalidad para obtener la data desde la BD por medio de un SP

            return R;
        }



    }
}
