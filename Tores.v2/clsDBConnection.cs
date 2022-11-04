using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Tores.v2
{
    public class clsDBConnection
    {
        SqlConnection vo_Conn = new SqlConnection(clsGlobal.DBConnectionString);

        public void ConnectionOC(char connectionRequest)
        {
            // Connection Açar-Kapar

            switch (connectionRequest)
            {
                case 'O':
                    vo_Conn.Open();
                    break;

                case 'C':
                    vo_Conn.Close();
                    break;
            }
        }

        public DataSet UserDataRead(string Query)
        {
            ConnectionOC('O'); // Connection açmak için

            SqlCommand vo_Cmd = new SqlCommand(Query, vo_Conn);

            // Parametrelerin doldurulması...
            vo_Cmd.Parameters.AddWithValue("@UName", clsGlobal.UName);
            vo_Cmd.Parameters.AddWithValue("@UPass", clsGlobal.UPass);

            SqlDataAdapter daUsers = new SqlDataAdapter(vo_Cmd); // data adapterri besleyecek command nesnesi belirtildi.

            DataSet dsUsers = new DataSet();

            daUsers.Fill(dsUsers, "Users"); // data adapter nesnesi dataseti dolduruyor.

            ConnectionOC('C'); // Connection kapatmak için

            return dsUsers; // çağrılan yere bir veri kümesi geri dönüyor.
        }
    }
}
