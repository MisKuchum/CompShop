
namespace FirstApp
{
    partial class FormPurchase
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
            this.dgvProc = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDateTime = new System.Windows.Forms.TextBox();
            this.txtSellerID = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnAction = new System.Windows.Forms.Button();
            this.cbTable = new System.Windows.Forms.ComboBox();
            this.cbAction = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProc
            // 
            this.dgvProc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProc.Location = new System.Drawing.Point(267, 68);
            this.dgvProc.Name = "dgvProc";
            this.dgvProc.Size = new System.Drawing.Size(727, 591);
            this.dgvProc.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(10, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 15);
            this.label8.TabIndex = 37;
            this.label8.Text = "Дата и время (гггг-мм-дд чч:мм:сс)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "ID продавца";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Количество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Наименование";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "ID";
            // 
            // txtDateTime
            // 
            this.txtDateTime.Location = new System.Drawing.Point(13, 368);
            this.txtDateTime.Name = "txtDateTime";
            this.txtDateTime.Size = new System.Drawing.Size(248, 20);
            this.txtDateTime.TabIndex = 31;
            // 
            // txtSellerID
            // 
            this.txtSellerID.Location = new System.Drawing.Point(13, 302);
            this.txtSellerID.Name = "txtSellerID";
            this.txtSellerID.Size = new System.Drawing.Size(248, 20);
            this.txtSellerID.TabIndex = 30;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(13, 234);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(248, 20);
            this.txtQuantity.TabIndex = 29;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(13, 166);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(248, 20);
            this.txtName.TabIndex = 28;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(13, 98);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(248, 20);
            this.txtId.TabIndex = 27;
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(56, 562);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(147, 50);
            this.btnAction.TabIndex = 26;
            this.btnAction.Text = "Text";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // cbTable
            // 
            this.cbTable.FormattingEnabled = true;
            this.cbTable.Items.AddRange(new object[] {
            "Материнские платы",
            "Видеокарты",
            "Процессоры",
            "Оперативная память",
            "Виды памяти",
            "Сокеты",
            "Сотрудники",
            "Продажи"});
            this.cbTable.Location = new System.Drawing.Point(140, 28);
            this.cbTable.Name = "cbTable";
            this.cbTable.Size = new System.Drawing.Size(121, 21);
            this.cbTable.TabIndex = 24;
            this.cbTable.SelectedIndexChanged += new System.EventHandler(this.cbTable_SelectedIndexChanged);
            // 
            // cbAction
            // 
            this.cbAction.FormattingEnabled = true;
            this.cbAction.Items.AddRange(new object[] {
            "Добавить",
            "Изменить",
            "Удалить"});
            this.cbAction.Location = new System.Drawing.Point(13, 28);
            this.cbAction.Name = "cbAction";
            this.cbAction.Size = new System.Drawing.Size(121, 21);
            this.cbAction.TabIndex = 23;
            this.cbAction.SelectedIndexChanged += new System.EventHandler(this.cbAction_SelectedIndexChanged);
            // 
            // FormPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 671);
            this.Controls.Add(this.dgvProc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDateTime);
            this.Controls.Add(this.txtSellerID);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.cbTable);
            this.Controls.Add(this.cbAction);
            this.Name = "FormPurchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Покупки";
            this.Load += new System.EventHandler(this.FormPurchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDateTime;
        private System.Windows.Forms.TextBox txtSellerID;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.ComboBox cbTable;
        private System.Windows.Forms.ComboBox cbAction;
    }
}