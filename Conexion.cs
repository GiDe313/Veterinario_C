using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;  //la libreria de MySql
using System.Data;  //la libreria del DataTable

namespace EjemploTabs_2021
{
    class Conexion
    {
        public MySqlConnection conexion; //variable que se encarga de conectarnos al servidor MySql

        public Conexion()
        { //el constructor de la clase
            conexion = new MySqlConnection("Server=127.0.0.1; Database=veterinario; Uid=root; Pwd=; Port=3306 ");
        }

        public Boolean loginInicial(String _DNI, String _password)
        {
            try
            {
                conexion.Open();

                MySqlCommand consulta = new MySqlCommand("SELECT * FROM login WHERE dni=@_DNI AND pass=@_password", conexion);
                consulta.Parameters.AddWithValue("@_DNI", _DNI);
                consulta.Parameters.AddWithValue("@_password", _password);

                MySqlDataReader resultado = consulta.ExecuteReader(); //guardo el resultado de la query
                if (resultado.Read())
                {
                    conexion.Close();
                    //si entra aquí es porque sí que estan bien el usuario y la contraseña
                    return true;
                }
                conexion.Close();
                return false;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        public Boolean insertausuario(String _DNI, String _Nombre, String _password)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("INSERT INTO login (dni, nombre, pass)  VALUES (@_DNI, @_Nombre, @_password, 0)", conexion);
                consulta.Parameters.AddWithValue("@_DNI", _DNI);
                consulta.Parameters.AddWithValue("@_Nombre", _Nombre);
                consulta.Parameters.AddWithValue("@_password", _password);

                int resultado = consulta.ExecuteNonQuery(); //Ejecuta el insert
                if (resultado > 0)
                {
                    conexion.Close();
                    //si entra aquí es porque ha hecho bien la inserción
                    return true;
                }
                conexion.Close();
                return false;
            }
            catch (MySqlException e)
            {
                return false;
                throw e;
            }
        }
    }
}