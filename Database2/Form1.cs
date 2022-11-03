using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBaglan_Click(object sender, EventArgs e)
        {
            string connectionString = null;
            string sqlText = null;

            SqlConnection connection;
            SqlCommand command;
            SqlDataReader dataReader;

            connectionString = @"Server= PHOKAIA\SQLEXPRESS; Database= Northwind;Integrated Security = SSPI";

            sqlText = "Select* from Products";

            connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                command = new SqlCommand(sqlText, connection);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    MessageBox.Show(dataReader.GetValue(1).ToString());
                }

                dataReader.Close();
                command.Dispose();
                connection.Close();


            }
            catch (Exception)
            {

                MessageBox.Show("Bağlantı açılamadı....");
            }



        }
    }


}
