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
    public partial class FormMb : Form
    {
        #region поля
        private string connstring = String.Format("Server={0};Port={1};" +
                "User Id={2};Password={3};Database={4};",
                "localhost", 5432, "postgres",
                "4a6z52269", "comp_shop");
        private NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;
        private DataTable dt;

        #endregion
        public string ActionName { get; set; }
        public string TableName;
        public FormMb()
        {
            InitializeComponent();
            Load += (s, e) =>
            {
                conn = new NpgsqlConnection(connstring);
                btnAction.Text = ActionName;
                cbAction.Text = ActionName;
                cbTable.Text = TableName;
                TxtActivation();
                SelectRequest();
            };
        }

        private void FormMb_Load(object sender, EventArgs e)
        {
            
        }

        private void Request()
        {
            try
            {
                conn.Open();
                switch (cbAction.Text)
                {
                    case "Добавить":
                        sql = String.Format("INSERT INTO public.\"Motherboard\" (\"Name\", " +
                        "\"CPU_socket\", \"Chipset\", \"RAM_type\", \"Price\", \"Quantity\") VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', {5})",
                        txtName.Text, txtSocket.Text, txtChipset.Text, txtRamType.Text, txtPrice.Text, txtQuantity.Text);
                        break;
                    case "Изменить":
                        sql = String.Format("UPDATE public.\"Motherboard\" SET \"Name\" = '{0}', \"CPU_socket\" = '{1}', " +
                            "\"Chipset\" = '{2}', \"RAM_type\" = '{3}', \"Price\" = {4}, \"Quantity\" = {5} WHERE \"MB_ID\" = {6}", 
                            txtName.Text, txtSocket.Text, txtChipset.Text, txtRamType.Text, txtPrice.Text, txtQuantity.Text, txtId.Text);
                        break;
                    case "Удалить":
                        sql = String.Format("DELETE FROM public.\"Motherboard\" WHERE \"MB_ID\" = {0}", txtId.Text);
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
                sql = "SELECT * FROM public.\"Motherboard\"";
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
                    txtChipset.Enabled = true;
                    txtRamType.Enabled = true;
                    txtPrice.Enabled = true;
                    break;

                case "Удалить":
                    txtId.Enabled = true;
                    txtName.Enabled = false;
                    txtSocket.Enabled = false;
                    txtChipset.Enabled = false;
                    txtRamType.Enabled = false;
                    txtPrice.Enabled = false;
                    break;

                case "Изменить":
                    txtId.Enabled = true;
                    txtName.Enabled = true;
                    txtSocket.Enabled = true;
                    txtChipset.Enabled = true;
                    txtRamType.Enabled = true;
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
