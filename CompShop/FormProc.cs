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
    public partial class FormProc : Form
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
        public FormProc()
        {
            InitializeComponent();
        }

        private void ProcForm_Load(object sender, EventArgs e)
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
                        sql = String.Format("INSERT INTO public.\"Processor\" (\"Name\", " +
                        "\"Socket\", \"Cores_num\", \"Price\", \"Quantity\") VALUES ('{0}', '{1}', '{2}', {3}, {4})",
                        txtName.Text, txtSocket.Text, txtCores.Text, txtPrice.Text, txtQuantity.Text);
                        break;
                    case "Изменить":
                        sql = String.Format("UPDATE public.\"Processor\" SET \"Name\" = '{0}', " +
                            "\"Socket\" = '{1}', \"Cores_num\" = {2}, \"Price\" = {3}, \"Quantity\" = {4} WHERE \"Proc_ID\" = {5}",
                            txtName.Text, txtSocket.Text, txtCores.Text, txtPrice.Text, txtQuantity.Text, txtId.Text);
                        break;
                    case "Удалить":
                        sql = String.Format("DELETE FROM public.\"Processor\" WHERE \"Proc_ID\" = {0}", txtId.Text);
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
                sql = "SELECT * FROM public.\"Processor\"";
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
                    txtSocket.Enabled = true;
                    txtCores.Enabled = true;
                    txtPrice.Enabled = true;
                    break;

                case "Удалить":
                    txtId.Enabled = true;
                    txtName.Enabled = false;
                    txtSocket.Enabled = false;
                    txtCores.Enabled = false;
                    txtPrice.Enabled = false;
                    break;

                case "Изменить":
                    txtId.Enabled = true;
                    txtName.Enabled = true;
                    txtSocket.Enabled = true;
                    txtCores.Enabled = true;
                    txtPrice.Enabled = true;
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
                case "Продажи":
                    FormPurchase formpurchase = new FormPurchase();
                    formpurchase.ActionName = this.cbAction.Text;
                    formpurchase.TableName = this.cbTable.Text;
                    this.Hide();
                    formpurchase.ShowDialog();
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
