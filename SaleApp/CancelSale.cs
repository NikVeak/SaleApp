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
    public partial class CancelSale : Form
    {
        DataBase dataBase = new DataBase();

        public CancelSale()
        {
            dataBase.OpenCon();
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataBase.CloseCon();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Не введено значение !", "Ошибка ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                try
                {
                    id = Convert.ToInt32(textBox1.Text);
                    string query = "CancelSale";
                    SqlCommand command = new SqlCommand(query, dataBase.getConnection());
                    command.CommandType = CommandType.StoredProcedure;
                    SqlParameter id_buy = new SqlParameter
                    {
                        ParameterName = "@id_buy",
                        Value = id
                    };
                    command.Parameters.Add(id_buy);
                    var res = command.ExecuteReader();
                    if (res.Read())
                    {
                        MessageBox.Show(res[1].ToString(), "Ошибка ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Продажа отменена !", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    dataBase.CloseCon();
                    this.Close();

                }
                catch(Exception exception)
                {
                    MessageBox.Show("Неверное значение !", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            catch (SqlException exception)
            {
                MessageBox.Show( "Операция не выполнена ! Выдано исключение вида: "+ exception.Data + " " + exception.Message, "Ошибка !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
