using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PROGRAMANDO_WF
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        #region GRUPO DE DATOS PERSONALES 

        string nombre;
        int edad, Hombre, Mujer;

        #region BOTON GUARDAR DATOS
        private void btnAgregar_Click(object sender, EventArgs e)
        {


            try
            {
                nombre = txtNombre.Text;
                edad = int.Parse(txtEdad.Text);
                rdbHombre.Text = "Hombre";
                rdbMujer.Text = "Mujer";
                if (rdbHombre.Checked)
                {
                    if (edad >= 18)
                    {
                        Hombre++;
                        dataPersonas.Rows.Add(nombre, edad, rdbHombre.Text, "Mayor Edad");
                    }
                    else
                    {
                        Hombre++;
                        dataPersonas.Rows.Add(nombre, edad, rdbHombre.Text, "Menor Edad");
                    }
                    lblHombres.Text = Hombre.ToString();
                }
                else if (rdbMujer.Checked)
                {
                    if (edad >= 18)
                    {
                        Mujer++;
                        dataPersonas.Rows.Add(nombre, edad, rdbMujer.Text, "Mayor Edad");
                    }
                    else
                    {
                        Mujer++;
                        dataPersonas.Rows.Add(nombre, edad, rdbMujer.Text, "Menor Edad");
                    }
                    lblMujeres.Text = Mujer.ToString();
                }
                else
                {
                    MessageBox.Show("Selecciona el Sexo");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Selecciona el Sexo");
            }

        }
        #endregion 

        #region BOTON LIMPIAR
        private void btnLimpiarInfo_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtEdad.Text = "";
            dataPersonas.Rows.Clear();
        }
        #endregion

        #region BOTON CERRAR
        private void btnSAlir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


        #endregion

        

    }
}
