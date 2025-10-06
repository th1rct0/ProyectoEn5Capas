using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using Entidades;


namespace VT_Ca
{
    public partial class Form1 : Form
    {
        P_Customer oCliente = new P_Customer();
        public Form1()
        {
            InitializeComponent();
        }
        private void IniDG()  // COn INidg se llena el datagridview
        {

            try
            {

                DGCustomer.DataSource = oCliente.GetAll().Tables[0];
                DGCustomer.Refresh();

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Formulario--->   " +Ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IniDG();
        }


        
    }
}

