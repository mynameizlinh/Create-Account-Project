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

namespace Create_Account_with_Email_or_Phone_Number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(local)\\SQLEXPRESS;Initial Catalog=userregcs;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[register]\r\n           ([firstname]\r\n           ,[lastname]\r\n           ,[address]\r\n           ,[gender]\r\n           ,[email]\r\n           ,[phone]\r\n           ,[username]\r\n           ,[password])\r\n     " +
                "VALUES\r\n           ('" + txtFName.Text + "', '" + txtLName.Text + "', '" + txtAddress.Text + "', '" + cmbGender.SelectedItem.ToString() + "', '" + txtEmail.Text + "', '" + txtPhone.Text + "', '" + txtUsername.Text + "', '" + txtPassword.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Registered!");

        }
    }
}
