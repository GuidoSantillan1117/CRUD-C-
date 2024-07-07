using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Barcosproyecto
{
    public static class AccesoDatos
    {
        private static string connectionString;
        private static SqlCommand cmd;
        private static SqlConnection conexion;

        static AccesoDatos()
        {
            connectionString = $"Server=DESKTOP-1V5M2A0;Database=Barcos;Integrated Security=true;TrustServerCertificate=True;";

        }
        public static bool GuardarDatosReparacion(Barco b1)
        {
            using (conexion = new SqlConnection(connectionString))
            {

                conexion.Open();
                string query = "INSERT INTO BarcosTaller(Alumno,Mensaje)" +
                               $"VALUES(@Alumno,@Mensaje)";
                cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Alumno", "Guido Santillan");
                cmd.Parameters.AddWithValue("@Mensaje", $"Se reparo el {b1.Nombre} a un costo de {b1.Costo} berries.");
                cmd.ExecuteNonQuery();
                return true;

            }
        }


        public static bool GuardarBarco(Barco b1)
        {
            using (conexion = new SqlConnection(connectionString))
            {

                conexion.Open();
                string query = "INSERT INTO CRUD_BARCOS(Nombre,Tripulacion,Estado,Costo,Tipo,Operacion)" +
                               $"VALUES(@Nombre,@Tripulacion,@Estado,@Costo,@Tipo,@Operacion)";
                cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Nombre", b1.Nombre);
                cmd.Parameters.AddWithValue("@Tripulacion", b1.Tripulacion);
                cmd.Parameters.AddWithValue("@Estado", b1.EstadoReparado);
                cmd.Parameters.AddWithValue("@Costo", b1.Costo);
                cmd.Parameters.AddWithValue("@Tipo", b1.GetType().Name);
                cmd.Parameters.AddWithValue("@Operacion", b1.Operacion.ToString());
                cmd.ExecuteNonQuery();
                return true;

            }
        }
        public static List<Barco> SeleccionarBarcos()
        {
            List<Barco> listaBarcos = new List<Barco>();

            using (conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                string query = "SELECT * FROM CRUD_BARCOS";
                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.GetString("Tipo") == "Marina")
                    {
                        Marina barcoMarina = new Marina(reader.GetString("Nombre"), reader.GetInt32("Tripulacion"));
                        barcoMarina.Id = reader.GetInt32("Id");
                        barcoMarina.EstadoReparado = reader.GetBoolean("Estado");
                        barcoMarina.Costo = (float)reader.GetDouble(reader.GetOrdinal("Costo"));
                        barcoMarina.Operacion = StringEnum(reader.GetString("Operacion"));
                        listaBarcos.Add(barcoMarina);


                    }
                    else if (reader.GetString("Tipo") == "Pirata")
                    {
                        Pirata barcoPirata = new Pirata (reader.GetString("Nombre"), reader.GetInt32("Tripulacion"));
                        barcoPirata.Id = reader.GetInt32("Id");
                        barcoPirata.EstadoReparado = reader.GetBoolean("Estado");
                        barcoPirata.Costo = (float)reader.GetDouble(reader.GetOrdinal("Costo"));
                        barcoPirata.Operacion = StringEnum(reader.GetString("Operacion"));

                        listaBarcos.Add(barcoPirata);
                    }
                }

            }
            return listaBarcos;

        }
        public static void ModificarBarcos(Barco b1)
        {
            using (conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                string query = "UPDATE CRUD_BARCOS SET Nombre = @Nombre, Tripulacion = @Tripulacion " + 
                    "WHERE Id =@id";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Nombre", b1.Nombre);
                cmd.Parameters.AddWithValue("@Id", b1.Id);
                cmd.Parameters.AddWithValue("@Tripulacion", b1.Tripulacion);

                cmd.ExecuteNonQuery();
            }

        }

        public static void ActualizarEstadoCosto(Barco b1)
        {
            using (conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                string query = "UPDATE CRUD_BARCOS SET Costo= @Costo, Estado = @Estado " + 
                    "WHERE Id =@id";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Costo", b1.Costo);
                cmd.Parameters.AddWithValue("@Id", b1.Id);
                cmd.Parameters.AddWithValue("@Estado", true);

                cmd.ExecuteNonQuery();
            }

        }
        public static void EliminarBarco(int id) 
        {
            using (conexion = new SqlConnection(connectionString))
            {
                conexion.Open();

                string query = "DELETE FROM CRUD_BARCOS WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }

        }
        public static EOperacion StringEnum(string str)
        {
            EOperacion operacion = EOperacion.Reparar_Mastil;

            switch (str)
            {
                case "Nada":
                    operacion = EOperacion.Nada;
                    break;
                case "Reparar_Mastil":
                    operacion = EOperacion.Reparar_Mastil;
                    break;
                case "Pintar":
                    operacion = EOperacion.Pintar;
                    break;
                case "Cambiar_Velas":
                    operacion = EOperacion.Cambiar_Velas;
                    break;
                case "Reparar_Mascaron":
                    operacion = EOperacion.Reparar_Mascaron;
                    break;
                case "Repara_Casco":
                    operacion = EOperacion.Repara_Casco;
                    break;
                case "Recargar_Cañones":
                    operacion = EOperacion.Recargar_Cañones;
                    break;
                default:
                    throw new ArgumentException($"Valor invalido: {str}");
            }

            return operacion;
        }


        //        Reparar_Mastil,
        //Pintar,
        //Cambiar_Velas,
        //Reparar_Mascaron,
        //Repara_Casco,
        //Recargar_Cañones
    }


}

