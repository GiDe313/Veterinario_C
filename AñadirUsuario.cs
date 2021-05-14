﻿using System;
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
    public partial class AñadirUsuario : Form
    {
        Conexion miConexion = new Conexion();

        public AñadirUsuario()
        {
            InitializeComponent();
        }


        private void insertaUsuario_Click(object sender, EventArgs e)
        {
            Conexion miConexion = new Conexion();
            Boolean resultado = miConexion.insertausuario(textBoxDNI.Text, textBoxNombre.Text, textBoxPASS.Text);
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
