﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public static class PaqueteDAO 
    {
        static SqlCommand comando;
        static SqlConnection conexion;

        /// <summary>
        /// El metodo inserta el tracking id y la direccion del paquete
        /// en Sql, controla y lanza si hay alguna excepcion.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool Insertar (Paquete p)
        {
            try
            {
                conexion.Open();
                StringBuilder cadena = new StringBuilder();

                cadena.AppendFormat("INSERT INTO Paquetes VALUES('{0}','{1}', 'Stomboli Carolina')", p.DireccionEntrega, p.TrackingID);
                comando = new SqlCommand(cadena.ToString(), conexion);
                comando.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch(Exception e)
            {
                throw new Exception("No se pudo guardar en la base de datos",e);
            }            
        }

        /// <summary>
        /// Constructor de PaqueteDAO, establece la conexion con Sql.
        /// </summary>
        static PaqueteDAO()
        {
            conexion = new SqlConnection("server=DESKTOP-U03MFFH;database=correo-sp-2017;integrated security=true");           
        }
    }
}
