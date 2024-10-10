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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        #region COMO CALCULAR EL NUMERO MAYOR DE TRES NUMEROS
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtnum1.Text);
            int num2 = int.Parse(txtnum2.Text);
            int num3 = int.Parse(txtnum3.Text);

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    lblnumero.Text = "" + num1;
                }
                else
                {
                    lblnumero.Text = "#:" + num3;
                }
            }
            else
            {
                if (num2 > num1)
                {
                    lblnumero.Text = "#:" + num2;
                }
                else
                {
                    lblnumero.Text = "#:" + num3;
                }
            }
        }

        private void btnLimpiarInfo_Click(object sender, EventArgs e)
        {
            txtnum1.Text = "";
            txtnum2.Text = "";
            txtnum3.Text = "";
        }

        private void btnSAlir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region MINI SISTEMA DE COMPRAS DE PAGINAS
        private void button3_Click(object sender, EventArgs e)
        {
            int CantidadPagina = int.Parse(txtnumpagina.Text);
            string tipo = ComboLista.Text;
            double pago = 0;

            switch (tipo)
            {
                case "Carta -> Blanco - Negro":
                    pago = CantidadPagina * 0.02;
                    txtpago.Text = "$" + pago;
                    break;
                case "Oficio-> Blanco - Negro":
                    pago = CantidadPagina * 0.05;
                    txtpago.Text = "$" + pago;
                    break;
                case "Carta -> Color":
                    pago = CantidadPagina * 0.25;
                    txtpago.Text = "$" + pago;
                    break;
                case "Oficio -> Color":
                    pago = CantidadPagina * 0.50;
                    txtpago.Text = "$" + pago;
                    break;
                default:
                    MessageBox.Show("Seleccione una Opcion");
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtnumpagina.Text = "";
            ComboLista.Text = "";
            txtpago.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region MINI LOGIN CON IF ANIDADOS
        private void button6_Click(object sender, EventArgs e)
        {
            string Usuario = txtUsuario.Text;
            string Contra = txtContrasenia.Text;
            try
            {
                if (Usuario == "Diego")
                {
                    lblMensajeInicio.Text = "Usuario Correcto";
                    if (int.Parse(Contra) + 50 == 100)
                    {
                        lblMensajeInicio.Text = "Correcto Puedes Pasar";
                    }
                    else
                    {
                        lblMensajeInicio.Text = "Incorrecto NO Puedes Pasar";
                    }
                }
                else
                {
                    lblMensajeInicio.Text = "DATOS ERRONEOS";
                }
            }
            catch (EvaluateException ex)
            {
                MessageBox.Show("Erro" + ex);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region LISTADO DE NOMBRES 
        /* ESTA LISTA TENDRIA QUE ESTAR AFUERA PARA QUE NO SE ESTE ACTUALIZANDO 
        LA LISTA DESDE CERO Y LOS PERMITA IR ALMACENANDO LOS DATOS QUE LE DIJITAMOS */
        List<string> Lista_Nombres = new List<string>();

        private void btnagregar_Click(object sender, EventArgs e)
        {
            string nombre;
            nombre = txtDatos.Text;
            Lista_Nombres.Add(nombre);

            ListaDatos.DataSource = null; // Los sirve para refrescar el LIST
            ListaDatos.DataSource = Lista_Nombres;
        }
        #endregion

        #region USO DEL IF ANIDADO + ELSE IF
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string Usuario = txtUser.Text;
            int Contra = int.Parse(txtContra.Text);

            try
            {
                if (Usuario == "Diego")
                {
                    MessageBox.Show("Usuario Correcto");
                    if (Contra < 99)
                    {
                        MessageBox.Show("Contraseña Correcta , Su numero es menor que 100");
                    }
                    else if (Contra > 101)
                    {
                        MessageBox.Show("Contraseña Correcta , Su numero es mayor que 100");
                    }
                    else
                    {
                        MessageBox.Show("Contraseña Incorrecta , Pruebe de Nuevo");
                    }
                }
                else
                {
                    MessageBox.Show("Usuario Incorrecto");
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Algo Salio Mal" + x);
            }

        }

        #endregion

        #region BOTON DONDE USAMOS EL FOR
        private void btnFor_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 1; i < 15;)
            {
                if (i <= 10)
                {
                    MessageBox.Show("Numero :" + i++);
                }
                else
                {
                    MessageBox.Show(">> Numero Mayor que 10 <<  :" + i++);
                    break;
                }

            }
        }
        #endregion

        #region BON COMO USAR EL DO WHILE
        private void button5_Click(object sender, EventArgs e)
        {
            string varx = "";
            int x = 0;
            do
            {
                varx += x.ToString() + "-";
                x++;

            } while (x < 11);
            MessageBox.Show(varx.ToString());
        }

        #endregion


        /// En un Arreglo podemos guardar una gran cantidad de Datos al mismo tiempo
        int tamanio = 0;
        string[] MiArreglo;
        private void btnGuardarlos_Click(object sender, EventArgs e)
        {

            tamanio = int.Parse(txtTamanio.Text);
            MiArreglo = new string[tamanio];
            
            for (int i = 0; i < tamanio; i++)
            {
                MiArreglo[i] = i.ToString();
            }
            txtNumerosArreglo.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tamanio; i++)
            {
                LstMostrarArreglos.Items.Add(MiArreglo[i].ToString());
                //Console.WriteLine("->" + MiArreglo[i]);
            }
        }
    }
}
