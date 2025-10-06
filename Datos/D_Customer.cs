using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using Entidades;
using System.Runtime.Remoting.Messaging;

namespace Datos
{
    public class D_Customer : CAD //tener acceso a la clase DEBSAccesoDatos para conectarnos a la base de datos
    {
        public DataSet GetAll()// Method to retrieve all customers
        {
            DataSet dataSet = new DataSet();
            DataSet DS = dataSet;

            try
            {
              

                   SqlCommand cmd = CrearComando("Customer_Get");
                DS = GetDS(cmd, "Customer_Get");
                  
            }
            catch (SqlException Ex)// Catch any exceptions that occur during the process

            {
                throw new Exception("Error Obteniendo todos los registros en D_CUSTOMER   " + Ex.Message, Ex);
                
            }
            



            return DS;
        }


    }
}
