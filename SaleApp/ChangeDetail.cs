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
    public partial class ChangeDetail : Form
    {
        public AddPosition f4;
        public bool run = false;
        DataBase dataBase = new DataBase();
        public ChangeDetail(AddPosition  form4)
        {
            dataBase.OpenCon();
            InitializeComponent();
            f4 = form4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!run)
            {
                MessageBox.Show("Не выбрано комплектующее !", "Ошибка ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                
                f4.textBox1.Text = textBox1.Text;
                dataBase.CloseCon();
                this.Close();
            }
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            string query = "select *from dbo.Категория where id_category = 4";
            SqlCommand command = new SqlCommand(query, dataBase.getConnection());
            
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    TreeNode node = new TreeNode((string)reader["name_category"]);
                    node.Nodes.Add(new TreeNode(""));
                    node.Tag = (int)reader["id_category"];
                    treeView1.Nodes.Add(node);
                }
                reader.Close();
            }
            catch (SqlException exception)
            {
                MessageBox.Show("Операция не выполнена ! Выдано исключение вида: " + exception.Data + " " + exception.Message, "Ошибка !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            LoadSubCategory(e.Node);
        }
        private void LoadSubCategory(TreeNode parentNode)
        {
            if ((int)parentNode.Tag > 4)
            {
                parentNode.Nodes.Clear();
                string query_detail = "select id_detail, title_detail, price from dbo.Комплектующее where id_category_detail = @id";
                SqlCommand command_detail = new SqlCommand(query_detail, dataBase.getConnection());
                command_detail.Parameters.AddWithValue("id", (int)parentNode.Tag);
                SqlDataReader reader_detail = command_detail.ExecuteReader();
                while (reader_detail.Read())
                {
                    TreeNode detail = new TreeNode((string)reader_detail["title_detail"]);
                    detail.Tag = (int)reader_detail["id_detail"];
                    parentNode.Nodes.Add(detail);

                }
                reader_detail.Close();
            }
            else
            {
                parentNode.Nodes.Clear();
                string query = "select *from dbo.Категория where parent_id = @Id and id_category <> 4";
                SqlCommand command = new SqlCommand(query, dataBase.getConnection());
                command.Parameters.AddWithValue("Id", (int)parentNode.Tag);

                DataTable dt = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                sqlDataAdapter.SelectCommand = command;
                sqlDataAdapter.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string name_category = dt.Rows[i]["name_category"].ToString();
                    TreeNode node = new TreeNode(name_category);
                    node.Tag = (int)dt.Rows[i]["id_category"];
                    node.Nodes.Add(new TreeNode(""));
                    parentNode.Nodes.Add(node);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private TreeNode SearchNode(string SearchText, TreeNode StartNode)
        {
            TreeNode node = null;
            while (StartNode != null)
            {
                if (StartNode.Text.ToLower().Contains(SearchText.ToLower()))
                {
                    node = StartNode; 
                    break;
                };
                if (StartNode.Nodes.Count != 0)
                {
                    StartNode.Nodes[0].BackColor = System.Drawing.Color.White;
                    node = SearchNode(SearchText, StartNode.Nodes[0]);
                    if (node != null)
                    {
                        break;
                    };
                };
                StartNode = StartNode.NextNode;
            };
            return node;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string SearchText = textBox1.Text;
            if (SearchText == "")
            {
                return;
            };
            TreeNode SelectedNode = SearchNode(SearchText, treeView1.Nodes[0]);
            if (SelectedNode != null)
            {
                treeView1.SelectedNode = SelectedNode;
                treeView1.SelectedNode.Expand();
                treeView1.SelectedNode.BackColor = System.Drawing.Color.LightGray;
            };
        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            string text = treeView1.SelectedNode.Text;
            textBox1.Text = text;
            string query = "select id_detail, price from dbo.Комплектующее where id_detail = @id";
            SqlCommand command = new SqlCommand(query, dataBase.getConnection());
            command.Parameters.AddWithValue("id", (int)treeView1.SelectedNode.Tag);
            var result = command.ExecuteReader();
            while (result.Read())
            {
                f4.ID_Detail.Text = result[0].ToString();
                f4.price.Text = result[1].ToString();
            }
            run = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
