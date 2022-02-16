using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstApp
{
    public partial class FormLogIn : Form
    {
        private string connstring = String.Format("Server={0};Port={1};" +
                "User Id={2};Password={3};Database={4};",
                "localhost", 5432, "postgres",
                "4a6z52269", "comp_shop");
        private NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;
        private DataTable dt;
        public FormLogIn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);            
        }

        private void Select_screen(string post, string username)
        {
            FormStartUserPage formstartuserpage = new FormStartUserPage();
            formstartuserpage.Username = username;
            this.Hide();
            formstartuserpage.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = String.Format("SELECT * FROM public.\"User\" WHERE (\"Username\" = '{0}')", txtLogin.Text);
                cmd = new NpgsqlCommand(sql, conn);
                var reader = cmd.ExecuteReader();
                string pwd = "NULL";
                string post = "NULL";

                if (reader.HasRows)
                {
                    reader.Read();
                    pwd = reader["Password"].ToString();
                    post = reader["Post"].ToString();
                }
                else
                {
                    MessageBox.Show("Введён неверный логин");
                }

                if (pwd.Equals(txtPwd.Text))
                {
                    Select_screen(post, txtLogin.Text);
                }
                else
                {
                    MessageBox.Show("Введён неверный пароль.");
                }

                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
