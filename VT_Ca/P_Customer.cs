using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using Entidades;
using Negocio;



namespace VT_Ca
{
    public class P_Customer
    {
        N_Customer N_Cus = new N_Customer();  // Instance of Business Logic Layer for Customer
        public DataSet GetAll() 
        {
            return N_Cus.GetAll(); // Method to retrieve all customers from the Business Logic Layer
        }

    }

}
