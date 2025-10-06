using DEBSAccesoSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data.SqlClient;


namespace Datos
{
    public class CAD: DEBSAccesoDatos //tener acceso a la clase DEBSAccesoDatos para conectarnos a la base de datos
    {
        public CAD()
        {
          

            /* string connectionString = "Server=localhost;Database=AdventureWorksLT2008R2;Trusted_Connection=True;";
              using (SqlConnection conn = new SqlConnection(connectionString)) ;*/
           
               // cConex = " Data Source=.;Initial Catalog=AdventureWorksLT2008R2;Trusted_Connection=Yes;"; //cadena de conexion a la base de datos
                //cConex = " Data Source =.; Initial Catalog = AdventureWorksLT2008R2; Trusted_Connection = Yes;";
               // conexion = new SqlConnection(cConex); //crear una nueva conexion

            try
            {
                cConex = " Data Source =(localdb)\\MSSQLLocalDB; Initial Catalog = AdventureWorksLT2008R2; Trusted_Connection = Yes;";
                ///data sorce= es el servidor; initial catalog= es la base de datos; trusted_connection= si es con autenticacion de windows, en mi caso queda asi por que no cree un usuario.
                ///ni contraseña en sql server. con trusted_connection=yes uso la autenticacion de windows.
                conexion = new SqlConnection(cConex); //crear una nueva conexion
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error desde DLL: " + ex.Message);
                Console.WriteLine("Origen: " + ex.Source);
                Console.WriteLine("Pila: " + ex.StackTrace);
            }








        }
    }
}
