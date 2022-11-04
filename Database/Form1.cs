using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindDataSet3.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter3.Fill(this.northwindDataSet3.Employees);
            // TODO: This line of code loads data into the 'northwindDataSet2.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter2.Fill(this.northwindDataSet2.Employees);
            // TODO: This line of code loads data into the 'northwindDataSet1.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter1.Fill(this.northwindDataSet1.Employees);
            // TODO: This line of code loads data into the 'northwindDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.northwindDataSet.Employees);

        }
    }
}
