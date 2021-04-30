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
            this.Hide();
            Menu ventana = new Menu();
            ventana.Show();

            //string dni = usuario.text; //leo lo que el usuario ha escrito en las cajas
            //string password = contraseña.text;
            //if (miconexion.logininicial(dni, password))
            //{
            //    this.hide();
            //    form1 ventana = new form1();
            //    ventana.show();

            //}
            //else {  //o la contraseña o el usuario son incorrectos
            //    messagebox.show("el usuario o la contraseña son incorrectos");
            //}
        }

        private void registrar_Click(object sender, EventArgs e)
        {
            AñadirUsuario ventana = new AñadirUsuario();
            ventana.Show();
        }

    }
}
