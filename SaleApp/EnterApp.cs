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

namespace SaleApp
{
    public partial class EnterApp : Form
    {
        public bool flag = false;
        public int idRab = 0;
        public string surnameRab = "";
        public string nameRab = "";
        public string lastname = "";
        public EnterApp()
        {
            
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            dataBase.OpenCon();
            String loginUser = textBox3.Text;
            String loginPassword = textBox4.Text;
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            String command =
                "Select *from dbo.Сотрудник where login = @uL AND password = @uP";
            SqlCommand commandUser = new SqlCommand(command, dataBase.getConnection());
            commandUser.Parameters.Add("@ul", SqlDbType.VarChar, 50).Value = loginUser;
            commandUser.Parameters.Add("@uP", SqlDbType.VarChar, 50).Value = loginPassword;
            sqlDataAdapter.SelectCommand = commandUser;
            sqlDataAdapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                idRab = dt.Rows[0].Field<int>("id_rab");
                surnameRab = dt.Rows[0].Field<string>("surname_rab");
                nameRab = dt.Rows[0].Field<string>("name_rab");
                lastname = dt.Rows[0].Field<string>("lastname");

                this.Hide();
                Main form2 = new Main(idRab, surnameRab, nameRab, lastname, this);
                form2.Show();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль !", "Ошибка !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
