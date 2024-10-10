using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace _3.PROGRAMANDO_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region BOTON QUE MUESTRA LOS MESES DEL AÑIO
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string Mes;
            for (int i = 1; i <= 12; i++)
            {
                Mes = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i);
                lstMeses.Items.Add(i + " -> " + Mes);
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstMeses.Items.Clear();
        }



        #endregion

        #region BOTON QUE GENERA NUMERO ALEATORIOS
        private void btnNumero_Click(object sender, EventArgs e)
        {
            lstNumRandom.Items.Clear();
            Random r = new Random();
            const int cantidad = 12;
            int num = 10, cont = 0;
            lstNumRandom.Items.Clear();
            while (cont < cantidad)
            {
                num = r.Next(10, 91);
                if (!lstNumRandom.Items.Contains(num))
                {
                    lstNumRandom.Items.Add(num);
                    cont++;
                }
            }
        }
        private void btnLimpiar3_Click(object sender, EventArgs e)
        {
            lstNumRandom.Items.Clear();
        }


        #endregion

        #region BOTON QUE MUESTRA LOS DIAS DE LA SEMANA
        private void btnMostrarDia_Click(object sender, EventArgs e)
        {

            lstDia.Items.Clear();
            string[] dias = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };
            foreach (var dia in dias)
            {
                lstDia.Items.Add(dia);
            }
        }

        private void btnLimpiar2_Click(object sender, EventArgs e)
        {
            lstDia.Items.Clear();
        }

        #endregion

        #region BOTON QUE GENERA TABLA DE MULTIPLICAR
        private void btnMostrarTabla_Click(object sender, EventArgs e)
        {

            for (int i = 1; i < 11; i++)
            {
                listBox1.Items.Add(" 5 " + " X " + i + "=" + 5 * i);
            }
        }

        private void btnLimpiarTabla_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
        #endregion


       #region COMO GUARDAR LIMPIAR INFORMACION Y MOSTRARLA
        int Total_Hombre, Total_Mujer;
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string Nombre = txtNombre.Text;
            int Edad = int.Parse(txtEdad.Text);
            if (rdbHombre.Checked)
            {
                if (Edad >= 18)
                {
                    dataPersonas.Rows.Add(Nombre, Edad, rdbHombre.Text, "Mayor Edad");
                }
                else
                {
                    dataPersonas.Rows.Add(Nombre, Edad, rdbHombre.Text, "Menor Edad");
                }
                Total_Hombre++;
            }
            else
            {
                if (Edad >= 18)
                {
                    dataPersonas.Rows.Add(Nombre, Edad, rdbMujer.Text, "Mayor Edad");
                }
                else
                {
                    dataPersonas.Rows.Add(Nombre, Edad, rdbMujer.Text, "Menor Edad");
                }
                Total_Mujer++;
            }
            //LIMPIAMOS LOS TEXBOX
            txtNombre.Text = "";
            txtEdad.Text = "";
            // MOSTRAMOS CUANTAS PERSONAS SON POR SEXO
            lblHombres.Text = "" + Total_Hombre;
            lblMujeres.Text = "" + Total_Mujer;
        }

        private void btnSAlir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 FormularioNuevo = new Form2();
            FormularioNuevo.Show();
        }

        private void btnLimpiarInfo_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtEdad.Text = "";
            dataPersonas.Rows.Clear();
        }

        #endregion


    }
}
