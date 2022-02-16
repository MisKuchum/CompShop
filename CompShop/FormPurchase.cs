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
    public partial class FormPurchase : Form
    {
        private string connstring = String.Format("Server={0};Port={1};" +
                "User Id={2};Password={3};Database={4};",
                "localhost", 5432, "postgres",
                "4a6z52269", "comp_shop");
        private NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;
        private DataTable dt;
        public string ActionName;
        public string TableName;
        public FormPurchase()
        {
            InitializeComponent();
        }

        private void FormPurchase_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            btnAction.Text = ActionName;
            cbAction.Text = ActionName;
            cbTable.Text = TableName;
            TxtActivation();
            SelectRequest();
        }

        private void Request()
        {
            try
            {
                conn.Open();
                switch (cbAction.Text)
                {
                    case "Добавить":
                        sql = String.Format("INSERT INTO public.\"Purchase\" (\"Name\", " +
                        "\"Quantity\", \"Seller_ID\", \"DateTime\") VALUES ('{0}', {1}, {2}, '{3}')",
                        txtName.Text, txtQuantity.Text, txtSellerID.Text, txtDateTime.Text);
                        break;
                    case "Изменить":
                        sql = String.Format("UPDATE public.\"Purchase\" SET \"Name\" = '{0}', " +
                            "\"Quantity\" = '{1}', \"Seller_ID\" = {2}, \"DateTime\" = {3} WHERE \"Purchase_ID\" = {4}",
                            txtName.Text, txtQuantity.Text, txtSellerID.Text, txtDateTime.Text, txtId.Text);
                        break;
                    case "Удалить":
                        sql = String.Format("DELETE FROM public.\"Purchase\" WHERE \"Purchase_ID\" = {0}", txtId.Text);
                        break;
                }

                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();
                SelectRequest();
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
                sql = "SELECT * FROM public.\"Purchase\"";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();
                dgvProc.DataSource = null;
                dgvProc.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void TxtActivation()
        {
            switch (cbAction.Text)
            {
                case "Добавить":
                    txtId.Enabled = false;
                    txtName.Enabled = true;
                    txtQuantity.Enabled = true;
                    txtSellerID.Enabled = true;
                    txtDateTime.Enabled = true;
                    break;

                case "Удалить":
                    txtId.Enabled = true;
                    txtName.Enabled = false;
                    txtQuantity.Enabled = false;
                    txtSellerID.Enabled = false;
                    txtDateTime.Enabled = false;
                    break;

                case "Изменить":
                    txtId.Enabled = true;
                    txtName.Enabled = true;
                    txtQuantity.Enabled = true;
                    txtSellerID.Enabled = true;
                    txtDateTime.Enabled = true;
                    break;
            }
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            Request();
        }

        private void cbTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbTable.Text)
            {
                case "Материнские платы":
                    FormMb formmb = new FormMb();
                    formmb.ActionName = this.cbAction.Text;
                    formmb.TableName = this.cbTable.Text;
                    this.Hide();
                    formmb.ShowDialog();
                    this.Close();
                    break;
                case "Видеокарты":
                    FormVcard formvcard = new FormVcard();
                    formvcard.ActionName = this.cbAction.Text;
                    formvcard.TableName = this.cbTable.Text;
                    this.Hide();
                    formvcard.ShowDialog();
                    this.Close();
                    break;
                case "Процессоры":
                    FormProc procform = new FormProc();
                    procform.ActionName = this.cbAction.Text;
                    procform.TableName = this.cbTable.Text;
                    this.Hide();
                    procform.ShowDialog();
                    this.Close();
                    break;
                case "Оперативная память":
                    FormRam formram = new FormRam();
                    formram.ActionName = this.cbAction.Text;
                    formram.TableName = this.cbTable.Text;
                    this.Hide();
                    formram.ShowDialog();
                    this.Close();
                    break;
                case "Виды памяти":
                    FormRamType formramtype = new FormRamType();
                    formramtype.ActionName = this.cbAction.Text;
                    formramtype.TableName = this.cbTable.Text;
                    this.Hide();
                    formramtype.ShowDialog();
                    this.Close();
                    break;
                case "Сокеты":
                    FormSocket formsocket = new FormSocket();
                    formsocket.ActionName = this.cbAction.Text;
                    formsocket.TableName = this.cbTable.Text;
                    this.Hide();
                    formsocket.ShowDialog();
                    this.Close();
                    break;
                case "Сотрудники":
                    FormEmployee formemployee = new FormEmployee();
                    formemployee.ActionName = this.cbAction.Text;
                    formemployee.TableName = this.cbTable.Text;
                    this.Hide();
                    formemployee.ShowDialog();
                    this.Close();
                    break;
            }
        }

        private void cbAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAction.Text = cbAction.Text;
            TxtActivation();
        }
    }
}
