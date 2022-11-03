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
    public partial class frmEmployee : Form
    {
        string connectionString = @"Server= PHOKAIA\SQLEXPRESS; Database= Northwind;Integrated Security = SSPI";
        string sqlText = null;

        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter dataAdapter;
        DataSet dSet;

        public frmEmployee()
        {
            InitializeComponent();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {

            KayitlariOku();

        }

        private void KayitlariOku()
        {
            sqlText = "Select EmployeeID,FirstName,LastName,City,Country from Employees";

            connection = new SqlConnection(connectionString);

            command = new SqlCommand(sqlText, connection);

            dataAdapter = new SqlDataAdapter();

            dataAdapter.SelectCommand = command;

            dSet = new DataSet();

            dataAdapter.Fill(dSet, "Employees");

            dgrdEmployees.DataSource = dSet;
            dgrdEmployees.DataMember = "Employees";

            VeriDoldur();

            connection.Close();
        }
        private void VeriDoldur()
        {
            tboxEmpID.Text = dSet.Tables[0].Rows[0]["EmployeeID"].ToString();
            tboxAd.Text = dSet.Tables[0].Rows[0]["FirstName"].ToString();
            tboxSoyad.Text = dSet.Tables[0].Rows[0]["LastName"].ToString();
            tboxCity.Text = dSet.Tables[0].Rows[0]["City"].ToString();
            tboxCountry.Text = dSet.Tables[0].Rows[0]["Country"].ToString();
        }
        private void btonAra_Click(object sender, EventArgs e)
        {
            if (tboxAra.Text != "")
            {
                int Deger = Convert.ToInt32(tboxAra.Text);

                command.Connection = connection;

                command.CommandText = "SELECT EmployeeID,FirstName,LastName,City,Country FROM Employees WHERE EmployeeID = @Deger"; // parametreli bir kullanım

                command.Parameters.AddWithValue("@Deger", Deger);

                connection.Open();

                using (var Datadapter = new SqlDataAdapter(command))
                {

                    dSet = new DataSet();
                    dataAdapter.Fill(dSet, "Employee");

                    dgrdEmployees.DataSource = dSet;
                    dgrdEmployees.DataMember = "Employee";

                    VeriDoldur();

                    command.Parameters.Clear();
                    connection.Close();



                }
            }
        }

        private void dgrdEmployees_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0) // datagrid içersinde/üzerinde bir satıra basıldıysa....
            {
                DataGridViewRow row = dgrdEmployees.Rows[e.RowIndex]; // hangi satıra basıldığını buluyor

                tboxEmpID.Text = row.Cells[0].Value.ToString();
                tboxAd.Text = row.Cells[1].Value.ToString();
                tboxSoyad.Text = row.Cells[2].Value.ToString();
                tboxCity.Text = row.Cells[3].Value.ToString();
                tboxCountry.Text = row.Cells[4].Value.ToString();
            }
        }

        private void btonEkle_Click(object sender, EventArgs e)
        {
            sqlText = "INSERT INTO Employees (LastName,FirstName,City,Country) VALUES(@LastName,@FirstName,@City,@Country)";

            command = new SqlCommand(sqlText, connection);

            command.Parameters.AddWithValue("@LastName", tboxSoyad.Text);
            command.Parameters.AddWithValue("@FirstName", tboxAd.Text);
            command.Parameters.AddWithValue("@City", tboxCity.Text);
            command.Parameters.AddWithValue("@Country", tboxCountry.Text);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();

                MessageBox.Show("Kayıt başarılı olarak eklendi....");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Kayıt ekleme başarısız....Hata kodu : " + ex.Message);
            }
            finally
            {
                KayitlariOku();
                VeriDoldur();
                connection.Close();
            }


        }

        private void btonGüncelle_Click(object sender, EventArgs e)
        {
            sqlText = "UPDATE Employees SET LastName=@LastName,FirstName=@FirstName,City=@City,Country=@Country WHERE EmployeeID=@EmployeeID";

            command = new SqlCommand(sqlText, connection);

            command.Parameters.AddWithValue("@LastName", tboxSoyad.Text);
            command.Parameters.AddWithValue("@FirstName", tboxAd.Text);
            command.Parameters.AddWithValue("@City", tboxCity.Text);
            command.Parameters.AddWithValue("@Country", tboxCountry.Text);
            command.Parameters.AddWithValue("@EmployeeID", Convert.ToInt32(tboxEmpID.Text));

            try
            {
                connection.Open();
                command.ExecuteNonQuery();

                MessageBox.Show("Kayıt başarılı olarak güncellendi....");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Kayıt güncelleme başarısız....Hata kodu : " + ex.Message);
            }
            finally
            {
                KayitlariOku();
                VeriDoldur();
                connection.Close();
            }

        }

        private void btonSil_Click(object sender, EventArgs e)
        {
//            sqlText = "DELETE FROM Employees WHERE EmployeeID=@EmployeeID";
            sqlText = "spDeleteEmployee";


            command = new SqlCommand(sqlText, connection);
            command.CommandType = CommandType.StoredProcedure;


            //command.Parameters.AddWithValue("@EmployeeID", Convert.ToInt32(tboxEmpID.Text));

            SqlParameter param = new SqlParameter("@EmployeeID", Convert.ToInt32(tboxEmpID.Text));

            param.Direction = ParameterDirection.Input;
            param.DbType = DbType.Int32;
            command.Parameters.Add(param);

            try
            {
                connection.Open();

                DialogResult dialogResult = MessageBox.Show( "Kayıt silinecek...Emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Kayıt başarılı olarak silindi....");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Kayıt silme başarısız....Hata kodu : " + ex.Message);
            }
            finally
            {
                KayitlariOku();
                VeriDoldur();
                connection.Close();
            }

        }
    }
}
