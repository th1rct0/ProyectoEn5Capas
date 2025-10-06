using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

using Entidades; //tener acceso a la clase Entidades
using Datos;  //tener acceso a la clase Datos

namespace Negocio
{
    public class N_Customer
    {
        D_Customer D_Cus = new D_Customer(); // Instance of Data Access Layer for Customer
        public DataSet GetAll()
        {
            return D_Cus.GetAll(); // Method to retrieve all customers from the Data Access Layer

        }
    }

}
