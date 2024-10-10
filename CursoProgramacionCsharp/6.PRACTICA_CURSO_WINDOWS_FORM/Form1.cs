using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6.PRACTICA_CURSO_WINDOWS_FORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // ES BUENO TENER LA LISTA AFUERA PARA PODER AGREGAR LOS NOMBRES Y QUE FUNCIONE BIEN 
        // Y EN EL METODO DEL BOTON SOLO AGREGAR LOS DATOS A LA LISTA
        List<string> ListaNombres = new List<string>();

        #region AQUI ESTA TODO SOBRE EL BOTON QUE AGREGA EDITAR Y ELIMINAR LOS NOMBRES A LA LISTA
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string nombre;
            nombre = txtNombre.Text;
            ListaNombres.Add(nombre);
            ListaBoxNombres.DataSource = null;
            ListaBoxNombres.DataSource = ListaNombres;
            txtNombre.Text = "";
        }
        private void btneliminar_Click(object sender, EventArgs e)
        {
            ListaNombres.Remove(txtNombre.Text);
            ListaBoxNombres.DataSource = null;
            ListaBoxNombres.DataSource = ListaNombres;
            txtNombre.Text = "";
        }
        private void btneditar_Click(object sender, EventArgs e)
        {
            var indice = ListaNombres.IndexOf(txtEditarNombre.Text); // BUSCA EL INDICE DEL NOMBRE
            ListaNombres.RemoveAt(indice);                           // AQUI LO REMUVE (EDITAR EL NOMBRE)
            ListaNombres.Insert(indice, txtNombre.Text);       // AGREGA EL NOMBRE EDITADO EN LA MISMA POSICION

            ListaBoxNombres.DataSource = null;
            ListaBoxNombres.DataSource = ListaNombres;
            txtNombre.Text = "";
            txtEditarNombre.Text = "";
        }
        #endregion

        #region AQUI ESTA TODO SOBRE EL BOTON CERRAR FORMULARIO
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion


        #region AQUI ESTA DE COMO HACER POO
        private void button1_Click(object sender, EventArgs e)
        {
            ClassPOO ClaseObjeto = new ClassPOO();
            ClaseObjeto.Mensaje();
        } 
        #endregion
    }
}
