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

        private void usuarios_Click(object sender, EventArgs e)
        {
            Usuarios ventana1 = new Usuarios();
            ventana1.Show();
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
            EliminarAnimal ventana4 = new EliminarAnimal();
            ventana4.Show();
        }

        private void buttonRRevision_Click(object sender, EventArgs e)
        {
            EliminarRevision ventana5 = new EliminarRevision();
            ventana5.Show();
        }
    }
}
