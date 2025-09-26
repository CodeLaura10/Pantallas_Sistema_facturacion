using System;
using Microsoft.Data.SqlClient;  

namespace Capa_Datos
{
    public class DALLogin
    {
        public bool ValidarLogin(string usuario, string contraseña)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(AppConfig.ConnString))
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM TBLSEGURIDAD " +
                                   "WHERE StrUsuario = @usuario AND StrClave = @clave";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@clave", contraseña);

                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la capa de datos: " + ex.Message);
            }
        }
    }
}


