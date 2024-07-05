using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using System.ComponentModel;
using System.Data;
using System.Security.Cryptography;
using Barco_tripulacion;

namespace Conexion
{
    public class AccesoDatos
    {
        string connectionStrig;

        public AccesoDatos(string server, string db)
        {
            connectionStrig = $"Server={server};Database={db};Integrated Security=true;TrustServerCertificate=True;";
        }

        private SqlConnection ObtenerConexion()
        {
            return new SqlConnection(connectionStrig);
        }


        public void InsertarReparacion(Barco b1) 
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                string query = "INSERT INTO Reparaciones(mensaje,nombre_alumno)" +
                    $"VALUES(@mensaje,@nombre_alumno)";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@mensaje", $"Se reparo el {b1.Nombre} a un costo de {b1.Costo} berries.");
                cmd.Parameters.AddWithValue("@nombre_alumno", "Guido Santillan");

            }
        }
    }


}
