using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploTabs_2021
{
    public partial class Menu : Form
    {
        Conexion miConexion = new Conexion();

        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AñadirUsuario ventana = new AñadirUsuario();
            ventana.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();  //cierra la aplicación
        }

        private void animales_Click(object sender, EventArgs e)
        {
            Animales ventana2 = new Animales();
            ventana2.Show();
        }

        private void revisiones_Click(object sender, EventArgs e)
        {
            Revisiones ventana3 = new Revisiones();
            ventana3.Show();
        }

        private void buttonEAnimal_Click(object sender, EventArgs e)
        {
            Aviso ventana4 = new Aviso();
            ventana4.Show();
        }

        private void buttonRRevision_Click(object sender, EventArgs e)
        {
            Aviso ventana5 = new Aviso();
            ventana5.Show();
        }

        private void buttonIAnimal_Click(object sender, EventArgs e)
        {
            Conexion miConexion = new Conexion();
            Boolean resultado = miConexion.insertaAnimal(textBoxNombre.Text, textBoxDueño.Text, dateTimePickerNacimiento.Value, textBoxGenero.Text, textBoxEspecie.Text, textBoxObservaciones.Text);
            if (resultado)
            {
                MessageBox.Show("INSERTADO CORRECTAMENTE");
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error inesperado y no se ha podido insertar. Pruebe mas tarde");
            }
        }

        private void buttonIRevision_Click(object sender, EventArgs e)
        {
            Conexion miConexion = new Conexion();
            Boolean resultado = miConexion.insertaRevision(textBoxNombre2.Text, dateTimePickerFecha.Value, textBoxMotivo.Text);
            if (resultado)
            {
                MessageBox.Show("INSERTADO CORRECTAMENTE");
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error inesperado y no se ha podido insertar. Pruebe mas tarde");
            }
        }
    }
}