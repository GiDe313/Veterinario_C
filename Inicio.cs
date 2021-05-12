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
    public partial class Inicio : Form
    {
        Conexion miConexion = new Conexion();

        public Inicio()
        {
            InitializeComponent();
        }

        private void botonLogin_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Menu ventana = new Menu();
            //ventana.Show();

            string dni = usuario.Text; //leo lo que el usuario ha escrito en las cajas
            string pass = contraseña.Text;
            if (miConexion.loginInicial(dni, pass))
            {
                this.Hide();
                Menu ventana = new Menu();
                ventana.Show();
            }
            else {  //o la contraseña o el usuario son incorrectos
                this.Hide();
                Inicio ventana2 = new Inicio();
                ventana2.Show();
            }
        }

        private void registrar_Click(object sender, EventArgs e)
        {
            AñadirUsuario ventana = new AñadirUsuario();
            ventana.Show();
        }

    }
}
