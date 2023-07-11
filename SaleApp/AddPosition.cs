using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleApp
{
    public partial class AddPosition : Form
    {
        public AddSale f3;
        public AddPosition(AddSale form3)
        {
            InitializeComponent();
            f3 = form3;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChangeDetail form5 = new ChangeDetail(this);
            form5.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 0)
            {
                MessageBox.Show("Количество не может быть равно 0 !", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if(textBox1.Text.Length == 0)
            {
                MessageBox.Show("Нужно выбрать комплектующее !", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                decimal summa = Convert.ToDecimal(numericUpDown1.Value) * Convert.ToDecimal(price.Text);
                f3.PositionsSale.Rows.Add(ID_Detail.Text, textBox1.Text, numericUpDown1.Value, Convert.ToDecimal(price.Text), summa);
                this.Close();
            }
        }
    }
}
