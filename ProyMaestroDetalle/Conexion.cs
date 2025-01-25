using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProyMaestroDetalle
{
    public class Conexion
    {

        public SqlConnection Conetar()
        {
            try
            {
                SqlConnection cone = new SqlConnection("Server=DESKTOP-00GNGBR;Database=Roho;Integrated Security=True");
                cone.Open();
                return cone;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
                return null;
            }
        }



        public void Cerrar(SqlConnection cone)
        {
            cone.Close();
        }

        public bool EjecutarComando(string cade)
        {
            SqlConnection con = this.Conetar();

            SqlCommand comando = new SqlCommand(cade, con);

            if (comando.ExecuteNonQuery() > 0)
            {
                this.Cerrar(con);
                return true;
            }
            else
            {
                this.Cerrar(con);
                return false;
            }


        }

        public DataSet LlenarDatos(string cade)
        {
            SqlConnection cone = this.Conetar();
            //TRY
            SqlDataAdapter ada = new SqlDataAdapter(cade, cone);
            DataSet data = new DataSet();
            ada.Fill(data);
            this.Cerrar(cone);
            return data;
        }
    }
}
