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

                MySqlCommand consulta = new MySqlCommand("SELECT * FROM login WHERE dni=@_DNI ", conexion);
                consulta.Parameters.AddWithValue("@_DNI", _DNI);

                MySqlDataReader resultado = consulta.ExecuteReader(); //guardo el resultado de la query
                if (resultado.Read())
                {
                    String passwordHash = resultado.GetString("pass");
                    if (BCrypt.Net.BCrypt.Verify(_password, passwordHash))
                        {
                        return true;
                        }
                    conexion.Close();
                    return false;
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
                MySqlCommand consulta = new MySqlCommand("INSERT INTO login (dni, nombre, pass)  VALUES (@dni, @nombre, @pass)", conexion);
                consulta.Parameters.AddWithValue("@dni", _DNI);
                consulta.Parameters.AddWithValue("@nombre", _Nombre);
                consulta.Parameters.AddWithValue("@pass", _password);

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

        public Boolean insertaAnimal(String _Nombre, String _Dueño, DateTime _Nacimiento, String _Genero, String _Especie, String _Observacion)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("INSERT INTO animal (Nombre, Dueño, Nacimiento, Genero, Especie, Observaciones)  VALUES (@nombre, @dueño, @nacimiento, @genero, @especie, @observaciones)", conexion);
                consulta.Parameters.AddWithValue("@nombre", _Nombre);
                consulta.Parameters.AddWithValue("@dueño", _Dueño);
                consulta.Parameters.AddWithValue("@nacimiento", _Nacimiento);
                consulta.Parameters.AddWithValue("@genero", _Genero);
                consulta.Parameters.AddWithValue("@especie", _Especie);
                consulta.Parameters.AddWithValue("@obsercaciones", _Observacion);

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

        public Boolean insertaRevision(String _Nombre, DateTime _Fecha, String _Motivo)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("INSERT INTO revisiones (Nombre, Fecha, Motivo)  VALUES (@nombre, @fecha, @motivo)", conexion);
                consulta.Parameters.AddWithValue("@nombre", _Nombre);
                consulta.Parameters.AddWithValue("@fecha", _Fecha);
                consulta.Parameters.AddWithValue("@motivo", _Motivo);

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