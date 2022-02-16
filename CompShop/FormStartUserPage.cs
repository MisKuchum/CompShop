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
    public partial class FormStartUserPage : Form
    {
        public string Username;
        private string Post;
        private string connstring = String.Format("Server={0};Port={1};" +
               "User Id={2};Password={3};Database={4};",
               "localhost", 5432, "postgres",
               "4a6z52269", "comp_shop");
        private NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;
        private DataTable dt;
        private string TableName;
        public FormStartUserPage()
        {
            InitializeComponent();
        }

        private void FormStartUserPage_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            lblUser.Text = String.Format("Вы вошли как: {0}", this.Username);
            Post = GetPost(Username);
            if (Post == "Администратор")
            {
                btnAdmin.Visible = true;
            }
        }

        private string GetPost(string username)
        {
            conn.Open();
            sql = $"SELECT \"Post\" FROM public.\"User\" WHERE \"Username\" = '{username}'";
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            var reader = cmd.ExecuteReader();
            reader.Read();
            string post = reader["Post"].ToString();
            conn.Close();

            return post;
        }

        private void cbTable_SelectedValueChanged(object sender, EventArgs e)
        {
            SelectTable();
        }

        private void SelectTable()
        {
            switch (cbTable.Text)
            {
                case "Материнские платы":
                    TableName = "Motherboard";
                    SelectRequest(TableName);
                    break;
                case "Процессоры":
                    TableName = "Processor";
                    SelectRequest(TableName);
                    break;
                case "Видеокарты":
                    TableName = "Video_card";
                    SelectRequest(TableName);
                    break;
                case "Оперативная память":
                    TableName = "RAM";
                    SelectRequest(TableName);
                    break;
            }
        }

        private void SelectRequest(string table)
        {
            try
            {
                conn.Open();
                sql = String.Format("SELECT * FROM public.\"{0}\"", table);
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();
                dgvTable.DataSource = null;
                dgvTable.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void linkChange_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLogIn form1 = new FormLogIn();
            this.Hide();
            form1.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int index = int.Parse(dgvTable.CurrentRow.Cells[0].Value.ToString());
            AddToCart(index, TableName);
        }

        private void AddToCart(int index, string table)
        {
            string id_name = "NULL";
            string name;
            int price;
            int storageQuantity;
            switch (table)
            {
                case "Motherboard":
                    id_name = "MB_ID";
                    break;
                case "Processor":
                    id_name = "Proc_ID";
                    break;
                case "Video_card":
                    id_name = "VGA_ID";
                    break;
                case "RAM":
                    id_name = "RAM_ID";
                    break;
            }
            // Получение товара, который нужно добавить
            conn.Open();
            sql = String.Format("SELECT \"Name\", \"Price\", \"Quantity\" FROM public.\"{0}\" WHERE \"{1}\" = {2}", table, id_name, index);
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            var reader = cmd.ExecuteReader();
            reader.Read();
            name = reader["Name"].ToString();
            storageQuantity = int.Parse(reader["Quantity"].ToString());
            price = int.Parse(reader["Price"].ToString());
            conn.Close();

            // Проверка наличия товара на складе

            if (storageQuantity.Equals(0))
            {
                MessageBox.Show("Товара нет в наличии на складе.");
                return;
            }

            // Проверка наличия товара в корзине
            conn.Open();
            sql = "SELECT * FROM public.\"Cart\"";
            cmd = new NpgsqlCommand(sql, conn);
            reader = cmd.ExecuteReader();
            bool flag = false;
            int product_id = 0;
            int quantity = 0;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (name.Equals(reader["Name"].ToString()))
                    {
                        product_id = int.Parse(reader["Product_id"].ToString());
                        quantity = int.Parse(reader["Quantity"].ToString()) + 1;
                        flag = true;
                    }
                }
            }
            conn.Close();

            // Добавление товара в корзину
            if (!flag)
            {
                conn.Open();
                sql = String.Format("INSERT INTO public.\"Cart\" (\"Name\", \"Quantity\", " +
                    "\"Price\") VALUES ('{0}', 1, {1})", name, price);
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();
            }
            else
            {
                conn.Open();
                sql = String.Format("UPDATE public.\"Cart\" SET \"Quantity\" = {0}, \"Price\" = {1}" +
                            "WHERE \"Product_id\" = {2}", quantity, price * quantity, product_id);
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();
            }

            // Изменение количества товара на складе
            conn.Open();
            sql = $"UPDATE public.\"{table}\" SET \"Quantity\" = {storageQuantity - 1} WHERE \"{id_name}\" = {index}";
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            conn.Close();

            SelectRequest(table);
            
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            FormCart formcart = new FormCart();
            formcart.Username = this.Username;
            formcart.ShowDialog();
            SelectTable();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            FormMb formmb = new FormMb();
            formmb.ActionName = "Добавить";
            formmb.TableName = "Материнские платы";
            formmb.ShowDialog();
        }
    }
}
