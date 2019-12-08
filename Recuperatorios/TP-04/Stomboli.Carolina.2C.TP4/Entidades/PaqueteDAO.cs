using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public static class PaqueteDAO //DESKTOP-U03MFFH
    {
        static SqlCommand comando;
        static SqlConnection conexion;
        
        public static bool Insertar (Paquete p)
        {
            conexion.Open();
            StringBuilder cadena = new StringBuilder();
           
            cadena.AppendFormat("INSERT INTO Paquetes VALUES('{0}','{1}', 'Stomboli Carolina')", p.DireccionEntrega, p.TrackingID);
            comando = new SqlCommand(cadena.ToString(), conexion);
            comando.ExecuteNonQuery();
            conexion.Close();

            return true;
        }

        static PaqueteDAO()
        {
            conexion = new SqlConnection(@"Data Source=DESKTOP-U03MFFH\SQLEXPRESS;Initial Catalog=correo-sp-2017;Integrated Security=True");
        }
    }
}
