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
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace SaleApp
{
    public partial class Main : Form
    {
        public AddSale main_form;
        public EnterApp form1;
        public bool flag = false;
        public int idRab = 0;
        public string surnameRab = "";
        public string nameRab = "";
        public string lastName = "";

        DataBase dataBase = new DataBase();
        public Main(int id, string surname, string name, string lastname, EnterApp form1)
        {
            idRab = id;
            surnameRab = surname;
            nameRab = name;
            lastName = lastname;
            dataBase.OpenCon();
            InitializeComponent();
            this.form1 = form1;
        }

        private void refreshDataGridViewLoadFrom(DataGridView dgw)
        {
            List<string[]> data = new List<string[]>();
            string queryString = "select * from dbo.Sales";
            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());
            command.CommandType = CommandType.Text;

            try
            {
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
                flag = true;
            }
            catch (SqlException exception)
            {
                MessageBox.Show("Операция не выполнена ! Выдано исключение вида: " + exception.Data + " " + exception.Message, "Ошибка !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshDataGridView(DataGridView dgw)
        {
            dataGridView1.Rows.Clear();
            List<string[]> data = new List<string[]>();
            string queryString = "select * from dbo.returnSale(@paramDate)";
            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());
            command.Parameters.Add("@paramDate", DbType.DateTime).Value = dateTimePicker1.Value.ToString();
            command.CommandType = CommandType.Text;

            try
            {
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
                flag = true;
            }
            catch (SqlException exception)
            {
                MessageBox.Show("Операция не выполнена ! Выдано исключение вида: " + exception.Data + " " + exception.Message, "Ошибка !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (flag)
            {
                dataGridView2.Rows.Clear();
                List<string[]> data = new List<string[]>();
                string id = (string)dataGridView1.CurrentRow.Cells[0].Value;
                string queryString = "select *from returnPositions(@id)";
                SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());
                command.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(id);

                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        data.Add(new string[4]);
                        data[data.Count - 1][0] = reader[0].ToString();
                        data[data.Count - 1][1] = reader[1].ToString();
                        data[data.Count - 1][2] = reader[2].ToString();
                        data[data.Count - 1][3] = reader[3].ToString();
                    }
                    reader.Close();
                    foreach (string[] s in data)
                    {
                        dataGridView2.Rows.Add(s);
                    }
                }
                catch (SqlException exception)
                {
                    MessageBox.Show("Операция не выполнена ! Выдано исключение вида: " + exception.Data + " " + exception.Message, "Ошибка !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

            }
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            RefreshDataGridView(dataGridView1);
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            RefreshDataGridView(dataGridView1);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Close();
            dataBase.CloseCon();
            form1.Close();
        }

        private void печатьЧекаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaseFont baseFont = BaseFont.CreateFont("C:\\Windows\\Fonts\\arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            PdfPTable table = new PdfPTable(dataGridView2.Columns.Count);
            PdfPCell cell = new PdfPCell(new Phrase("Чек №" + id.ToString(), font));
            table.AddCell(cell);

            for (int j = 0; j < dataGridView1.Columns.Count; j++)
            {
                if (j != 0 && j != 2 && j != 3)
                {
                    cell = new PdfPCell(new Phrase(dataGridView1.CurrentRow.Cells[j].Value.ToString(), font));
                    table.AddCell(cell);
                }

            }

            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView2.Columns.Count; j++)
                {
                    if (dataGridView2.Rows[i].Cells[j].Value != null)
                    {
                        table.AddCell(new Phrase(dataGridView2.Rows[i].Cells[j].Value.ToString(), font));
                    }
                }
            }
            using (FileStream stream = new FileStream("C:\\Users\\hyppe\\source\\repos\\SaleApp\\SaleApp\\" + "sale_" + id.ToString() + "_check.pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(table);
                pdfDoc.Close();
                stream.Close();
                MessageBox.Show("Чек сохранен !", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            
        }


        private void оформитьПродажуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSale form3 = new AddSale(this, idRab, surnameRab, nameRab, lastName);
            form3.ShowDialog();
            RefreshDataGridView(dataGridView1);
        }

        private void отменитьПродажуToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CancelSale form8 = new CancelSale();
            form8.Show();
        }

        private void анализПоСотрудникамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = 1;
            AnalisSale form6 = new AnalisSale(i);
            form6.Show();
        }

        private void анализКомплектующихToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = 2;
            AnalisSale form6 = new AnalisSale(i);
            form6.Show();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы точно хотите выйти из приложения ?", "Вопрос", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                dataBase.CloseCon();
                form1.Close();
            }else
            {

            }
        }
    }
}
