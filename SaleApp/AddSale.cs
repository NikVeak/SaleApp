using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Data.SqlClient;

namespace SaleApp
{
    public partial class AddSale : Form
    {
        public Main form2;
        public int idRab = 0;
        public string surnameRab = "";
        public string nameRab = "";
        public string lastName = "";
        DataBase dataBase = new DataBase();
        public AddSale(Main form2, int id, string surname, string name, string lastname)
        {
            InitializeComponent();
            dataBase.OpenCon();
            this.form2 = form2;
            idRab = id;
            surnameRab = surname;
            nameRab = name;
            lastName = lastname;
        }

        // add position
        private void button1_Click(object sender, EventArgs e)
        {
            AddPosition form4 = new AddPosition(this);
            form4.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            fio.Text = surnameRab + " " + nameRab + " " + lastName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы точно хотите удалить позицию ?", "Вопрос", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                int a = PositionsSale.CurrentRow.Index;
                PositionsSale.Rows.Remove(PositionsSale.Rows[a]);
            }else
            {

            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (PositionsSale.Rows.Count == 1)
            {
                MessageBox.Show("В продаже должна быть минимум одна позиция !", "Ошибка !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            { 
                DataTable dataTable = ConvertDataTable(PositionsSale);
                var jsonStringBuilder = new StringBuilder();
                if (dataTable.Rows.Count > 0)
                {
                    jsonStringBuilder.Append("[");
                    for (int i = 0; i < dataTable.Rows.Count - 1; i++)
                    {
                        jsonStringBuilder.Append("{");
                        jsonStringBuilder.AppendFormat("\"{0}\":{1},\"{2}\":{3}",
                            dataTable.Columns[2].ColumnName.ToString(),
                            dataTable.Rows[i][2],
                            dataTable.Columns[0].ColumnName.ToString(),
                            dataTable.Rows[i][0]);
                        if (i == dataTable.Rows.Count - 2)
                        {
                            jsonStringBuilder.Append("}");
                        }
                        else
                        {
                            jsonStringBuilder.Append("},");
                        }

                    }
                    jsonStringBuilder.Append("]");
                }
                try
                {

                    dataBase.sqlConnection.InfoMessage += new SqlInfoMessageEventHandler(SqlConnectionInfo_message);
                    string jsonString = jsonStringBuilder.ToString();
                    string query = "AddSale";
                    SqlCommand command = new SqlCommand(query, dataBase.getConnection());
                   
                    command.CommandType = CommandType.StoredProcedure;
                    SqlParameter id_rab = new SqlParameter
                    {
                        ParameterName = "@id_rab",
                        Value = idRab
                    };
                    command.Parameters.Add(id_rab);


                    SqlParameter json = new SqlParameter
                    {
                        ParameterName = "@json",
                        Value = jsonString
                    };
                    command.Parameters.Add(json);

                    SqlDataReader result = command.ExecuteReader();

                    string error = "";

                    if (result.Read())
                    {
                        foreach (DataGridViewRow row in PositionsSale.Rows)
                        {
                            if (row.Cells["id_detail"].Value != null)
                            {
                                if (row.Cells["id_detail"].Value as string == result[0].ToString())
                                {
                                    error += "\n " + row.Cells[1].Value + " в количестве " + row.Cells[2].Value + " шт. ";
                                    row.Cells[3].Style.BackColor = System.Drawing.Color.Red;
                                    row.Cells[1].Style.BackColor = System.Drawing.Color.Red;
                                    row.Cells[2].Style.BackColor = System.Drawing.Color.Red;
                                    row.Cells[4].Style.BackColor = System.Drawing.Color.Red;
                                }
                            }

                        }
                        MessageBox.Show("Недостаточно следующих комплектующих: "+error, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        result.Close();
                    }
                    else
                    {
                        MessageBox.Show("Продажа добавлена !", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Операция не выполнена ! Выдано исключение вида: " + exception.Data + " " + exception.Message, "Ошибка !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            
        }

        public static void SqlConnectionInfo_message(Object sender, SqlInfoMessageEventArgs e)
        {
            MessageBox.Show("Info: " + sender + ", " + e);
        }

        public static DataTable ConvertDataTable(DataGridView dgw)
        {
            DataTable dt = new DataTable();
            foreach (DataGridViewColumn col in dgw.Columns)
            {
                dt.Columns.Add(col.Name);
            }
            foreach (DataGridViewRow row in dgw.Rows)
            {
                DataRow dRow = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                dt.Rows.Add(dRow);
            }
            return dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (PositionsSale.Rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Вы внесли изменения! Изменения будут утеряны, продолжить?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    dataBase.CloseCon();
                    this.Close();
                }else
                {
                    
                }
            }

        }
    }
}
