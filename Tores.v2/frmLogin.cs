using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tores.v2
{
    public partial class frmLogin : Form
    {
        clsDBConnection clsDBConnection = new clsDBConnection();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.Text = clsGlobal.SystemName;
        }

        private void btonLogin_Click(object sender, EventArgs e)
        {
            clsGlobal.UName = tboxUName.Text;
            clsGlobal.UPass = tboxUPass.Text;

            // artık değerler alındı. DB tarafında varmı yok mu kontrol...

            string vs_Select;

            vs_Select = "SELECT UserID,UserFName,UserLName,UserTypeID,TypeDesc,UserDeptID,DeptName FROM datUser ";
            vs_Select += "INNER JOIN prmUserType ON datUser.UserTypeID=prmUserType.UTypeID ";
            vs_Select += "INNER JOIN prmDepartment ON datUser.UserDeptID=prmDepartment.DeptID ";
            vs_Select += "WHERE UName = @UName AND UPass = @UPass";

            DataSet dsUsers = clsDBConnection.UserDataRead(vs_Select);
            DataTable dtUsers = dsUsers.Tables[0];

            // kayıt grldi mi gelmedi mi

            if (dtUsers.Rows.Count > 0) // db tarafından kayıt geldimi
            {
                MessageBox.Show("Kayıt var");
            }
            else
            {
                MessageBox.Show("Böyle bir kayıt yok...");
            }



        }
    }
}
