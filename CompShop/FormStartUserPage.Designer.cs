
namespace FirstApp
{
    partial class FormStartUserPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStartUserPage));
            this.lblUser = new System.Windows.Forms.Label();
            this.linkChange = new System.Windows.Forms.LinkLabel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.cbTable = new System.Windows.Forms.ComboBox();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(593, 15);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(106, 13);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Вы вошли как: User";
            // 
            // linkChange
            // 
            this.linkChange.AutoSize = true;
            this.linkChange.LinkColor = System.Drawing.Color.Black;
            this.linkChange.Location = new System.Drawing.Point(593, 30);
            this.linkChange.Name = "linkChange";
            this.linkChange.Size = new System.Drawing.Size(125, 13);
            this.linkChange.TabIndex = 2;
            this.linkChange.TabStop = true;
            this.linkChange.Text = "Сменить пользователя";
            this.linkChange.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkChange.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkChange_LinkClicked);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(220, 9);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(163, 45);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Добавить выделенный товар в корзину";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvTable
            // 
            this.dgvTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Location = new System.Drawing.Point(12, 67);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.Size = new System.Drawing.Size(715, 595);
            this.dgvTable.TabIndex = 6;
            // 
            // cbTable
            // 
            this.cbTable.FormattingEnabled = true;
            this.cbTable.Items.AddRange(new object[] {
            "Материнские платы",
            "Видеокарты",
            "Процессоры",
            "Оперативная память"});
            this.cbTable.Location = new System.Drawing.Point(12, 22);
            this.cbTable.Name = "cbTable";
            this.cbTable.Size = new System.Drawing.Size(186, 21);
            this.cbTable.TabIndex = 7;
            this.cbTable.SelectedValueChanged += new System.EventHandler(this.cbTable_SelectedValueChanged);
            // 
            // btnCart
            // 
            this.btnCart.BackColor = System.Drawing.SystemColors.Control;
            this.btnCart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCart.BackgroundImage")));
            this.btnCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCart.FlatAppearance.BorderSize = 0;
            this.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCart.Location = new System.Drawing.Point(554, 15);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(33, 32);
            this.btnCart.TabIndex = 8;
            this.btnCart.UseVisualStyleBackColor = false;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(402, 9);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(121, 45);
            this.btnAdmin.TabIndex = 3;
            this.btnAdmin.Text = "Панель администратора";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Visible = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // FormStartUserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 671);
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.cbTable);
            this.Controls.Add(this.dgvTable);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.linkChange);
            this.Controls.Add(this.lblUser);
            this.Name = "FormStartUserPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оформление покупки";
            this.Load += new System.EventHandler(this.FormStartUserPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.LinkLabel linkChange;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.ComboBox cbTable;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Button btnAdmin;
    }
}