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
    public partial class AnalisSale : Form
    {
        DataBase dataBase = new DataBase();
        public int flag;
        public AnalisSale(int flag)
        {
            dataBase.OpenCon();
            InitializeComponent();
            this.flag = flag;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                try
                {
                    dataGridView1.Columns.Clear();
                    dataGridView1.Columns.Add("FIO", "ФИО");
                    dataGridView1.Columns.Add("Count", "Количество");
                    dataGridView1.Columns.Add("Summa", "Сумма");
                    dataGridView1.Rows.Clear();
                    string query = "SELECT *from AnalizSaleRab(@date1, @date2) order by Сумма";

                    SqlCommand command = new SqlCommand(query, dataBase.getConnection());
                    command.Parameters.Add("@date1", DbType.DateTime).Value = dateTimePicker1.Value.ToString();
                    command.Parameters.Add("@date2", DbType.DateTime).Value = dateTimePicker2.Value.ToString();
                    List<string[]> data = new List<string[]>();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        data.Add(new string[3]);
                        data[data.Count - 1][0] = reader[0].ToString();
                        data[data.Count - 1][1] = reader[1].ToString();
                        data[data.Count - 1][2] = reader[2].ToString();
                    }
                    reader.Close();
                    foreach (string[] s in data)
                    {
                        dataGridView1.Rows.Add(s);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Операция не выполнена ! Выдано исключение вида: " + exception.Data + " " + exception.Message, "Ошибка !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    dataGridView1.Rows.Clear();
                    dataGridView1.Columns.Clear();
                    dataGridView1.Columns.Add("Category", "Категория");
                    dataGridView1.Columns.Add("Detail", "Комплектующее");
                    dataGridView1.Columns.Add("TypeSale", "Тип продажи");
                    dataGridView1.Columns.Add("Count", "Количество");
                    dataGridView1.Columns.Add("Summa", "Сумма");
                    string query = "SELECT *from AnalizSaleCategory(@date1, @date2) order by Сумма desc";

                    SqlCommand command = new SqlCommand(query, dataBase.getConnection());
                    command.Parameters.Add("@date1", DbType.DateTime).Value = dateTimePicker1.Value.ToString();
                    command.Parameters.Add("@date2", DbType.DateTime).Value = dateTimePicker2.Value.ToString();
                    List<string[]> data = new List<string[]>();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    
                    {
                        data.Add(new string[5]);
                        data[data.Count - 1][0] = reader[0].ToString();
                        data[data.Count - 1][1] = reader[1].ToString();
                        data[data.Count - 1][2] = reader[2].ToString();
                        data[data.Count - 1][3] = reader[3].ToString();
                        data[data.Count - 1][4] = reader[4].ToString();
                    }
                    reader.Close();
                    foreach (string[] s in data)
                    {
                        dataGridView1.Rows.Add(s);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Операция не выполнена ! Выдано исключение вида: " + exception.Data + " " + exception.Message, "Ошибка !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
