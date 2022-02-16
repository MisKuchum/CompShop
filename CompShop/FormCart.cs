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
    public partial class FormCart : Form
    {
        public string Username;
        private string connstring = String.Format("Server={0};Port={1};" +
               "User Id={2};Password={3};Database={4};",
               "localhost", 5432, "postgres",
               "4a6z52269", "comp_shop");
        private NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;
        private DataTable dt;
        public FormCart()
        {
            InitializeComponent();
        }

        private void FormCart_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;

            this.Hide();
        }

        private void FormCart_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            SelectRequest();
            UpdateSum();
        }

        private void UpdateSum()
        {
            int sum = 0;
            try
            {
                conn.Open();
                sql = "SELECT \"Price\" FROM public.\"Cart\"";
                cmd = new NpgsqlCommand(sql, conn);
                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        sum += int.Parse(reader["Price"].ToString());
                    }
                }
                conn.Close();
                lblSum.Text = sum.ToString();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void SelectRequest()
        {
            try
            {
                conn.Open();
                sql = "SELECT * FROM public.\"Cart\"";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dgvCart.DataSource = null;
                dgvCart.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            try
            {
                // Получение текущего времени
                conn.Open();
                sql = "SELECT NOW()::timestamp;";
                cmd = new NpgsqlCommand(sql, conn);
                var reader = cmd.ExecuteReader();
                reader.Read();
                string dateTime = reader.GetValue(0).ToString();

                string day = dateTime.Substring(0, 2);
                string month = dateTime.Substring(3, 2);
                string year = dateTime.Substring(6, 4);
                string hours = dateTime.Substring(11, 2);
                string minutes = dateTime.Substring(14, 2);
                string seconds = dateTime.Substring(17, 2);

                dateTime = $"{year}-{month}-{day} {hours}:{minutes}:{seconds}";

                conn.Close();

                // Получение id текущего продавца
                conn.Open();
                sql = String.Format("SELECT \"User_ID\" FROM public.\"User\" WHERE \"Username\" = '{0}'", Username);
                cmd = new NpgsqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                reader.Read();
                string user_id = reader.GetValue(0).ToString();
                conn.Close();

                // Получение списка товаров из корзины
                conn.Open();
                sql = "SELECT \"Name\", \"Quantity\" FROM public.\"Cart\"";
                cmd = new NpgsqlCommand(sql, conn);
                Dictionary<string, string> cart = new Dictionary<string, string>();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cart.Add(reader.GetValue(0).ToString(), reader.GetValue(1).ToString());
                    }
                }
                conn.Close();

                // Занесение товаров из корзины в новую покупку
                foreach (var product in cart)
                {
                    conn.Open();
                    sql = String.Format("INSERT INTO public.\"Purchase\" (\"Name\", \"Quantity\"," +
                                    "\"Seller_ID\", \"DateTime\") VALUES ('{0}', {1}, {2}, '{3}')",
                                    product.Key, product.Value, user_id, dateTime);
                    cmd = new NpgsqlCommand(sql, conn);
                    dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    conn.Close();
                }

                // Очистка корзины
                conn.Open();
                sql = "DELETE FROM public.\"Cart\";" +
                      "ALTER SEQUENCE \"Cart_Product_id_seq\" RESTART;";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();
                this.Hide();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = int.Parse(dgvCart.CurrentRow.Cells[0].Value.ToString());
            DelFromCart(index);
            UpdateSum();
        }

        private void DelFromCart(int index)
        {
            conn.Open();
            sql = $"SELECT * FROM public.\"Cart\" WHERE \"Product_id\" = {index}";
            cmd = new NpgsqlCommand(sql, conn);
            var reader = cmd.ExecuteReader();
            reader.Read();
            int quantity = int.Parse(reader["Quantity"].ToString());
            int price = int.Parse(reader["Price"].ToString());
            string name = reader["Name"].ToString();
            conn.Close();

            if (quantity != 1)
            {
                conn.Open();
                sql = $"UPDATE public.\"Cart\" SET \"Quantity\" = {quantity - 1}, \"Price\" = {price / quantity * (quantity - 1)} WHERE \"Product_id\" = {index}";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();
            }
            else
            {
                conn.Open();
                sql = $"DELETE FROM public.\"Cart\" WHERE \"Product_id\" = {index}";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();
            }

            conn.Close();
            UpdateSum();
            SelectRequest();
            AddToStorage(name);
        }

        private void AddToStorage(string name)
        {
            string table = DefineTable(name);

            conn.Open();
            sql = $"SELECT \"Quantity\" FROM public.\"{table}\" WHERE \"Name\" = '{name}'";
            cmd = new NpgsqlCommand(sql, conn);
            var reader = cmd.ExecuteReader();
            reader.Read();
            int quantity = int.Parse(reader["Quantity"].ToString());
            conn.Close();

            conn.Open();
            sql = $"UPDATE public.\"{table}\" SET \"Quantity\" = {quantity + 1} WHERE \"Name\" = '{name}'";
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            conn.Close();
        }

        private string DefineTable(string name)
        {
            List<string> tables = new List<string>() { "Motherboard", "Processor", "RAM", "Video_card" };
            foreach(string table  in tables)
            {
                conn.Open();
                sql = $"SELECT * FROM public.\"{table}\" WHERE \"Name\" = '{name}'";
                cmd = new NpgsqlCommand(sql, conn);
                var reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    conn.Close();
                    return table;
                }
                else
                {
                    conn.Close();
                }
            }
            return "No table";
        }
    }
}