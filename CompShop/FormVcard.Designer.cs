
namespace FirstApp
{
    partial class FormVcard
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
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtProcFreq = new System.Windows.Forms.TextBox();
            this.txtVidType = new System.Windows.Forms.TextBox();
            this.txtVidCapacity = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnAction = new System.Windows.Forms.Button();
            this.cbTable = new System.Windows.Forms.ComboBox();
            this.cbAction = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProc
            // 
            this.dgvProc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProc.Location = new System.Drawing.Point(266, 68);
            this.dgvProc.Name = "dgvProc";
            this.dgvProc.Size = new System.Drawing.Size(727, 591);
            this.dgvProc.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-245, 901);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Цена";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 60;
            this.label5.Text = "Цена";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 349);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 13);
            this.label8.TabIndex = 59;
            this.label8.Text = "Частота графического процессора";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 58;
            this.label4.Text = "Тип видеопамяти";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "Объём видеопамяти";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Наименование";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "ID";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(12, 426);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(248, 20);
            this.txtPrice.TabIndex = 54;
            // 
            // txtProcFreq
            // 
            this.txtProcFreq.Location = new System.Drawing.Point(12, 365);
            this.txtProcFreq.Name = "txtProcFreq";
            this.txtProcFreq.Size = new System.Drawing.Size(248, 20);
            this.txtProcFreq.TabIndex = 53;
            // 
            // txtVidType
            // 
            this.txtVidType.Location = new System.Drawing.Point(12, 299);
            this.txtVidType.Name = "txtVidType";
            this.txtVidType.Size = new System.Drawing.Size(248, 20);
            this.txtVidType.TabIndex = 52;
            // 
            // txtVidCapacity
            // 
            this.txtVidCapacity.Location = new System.Drawing.Point(12, 231);
            this.txtVidCapacity.Name = "txtVidCapacity";
            this.txtVidCapacity.Size = new System.Drawing.Size(248, 20);
            this.txtVidCapacity.TabIndex = 51;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 163);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(248, 20);
            this.txtName.TabIndex = 50;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(12, 98);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(248, 20);
            this.txtId.TabIndex = 49;
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(55, 562);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(147, 50);
            this.btnAction.TabIndex = 47;
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
            this.cbTable.Location = new System.Drawing.Point(139, 28);
            this.cbTable.Name = "cbTable";
            this.cbTable.Size = new System.Drawing.Size(121, 21);
            this.cbTable.TabIndex = 45;
            this.cbTable.SelectedIndexChanged += new System.EventHandler(this.cbTable_SelectedIndexChanged);
            // 
            // cbAction
            // 
            this.cbAction.FormattingEnabled = true;
            this.cbAction.Items.AddRange(new object[] {
            "Добавить",
            "Изменить",
            "Удалить"});
            this.cbAction.Location = new System.Drawing.Point(12, 28);
            this.cbAction.Name = "cbAction";
            this.cbAction.Size = new System.Drawing.Size(121, 21);
            this.cbAction.TabIndex = 44;
            this.cbAction.SelectedIndexChanged += new System.EventHandler(this.cbAction_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-245, 901);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Цена";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(12, 486);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(248, 20);
            this.txtQuantity.TabIndex = 54;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 470);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 60;
            this.label9.Text = "Количество";
            // 
            // FormVcard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 671);
            this.Controls.Add(this.dgvProc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtProcFreq);
            this.Controls.Add(this.txtVidType);
            this.Controls.Add(this.txtVidCapacity);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.cbTable);
            this.Controls.Add(this.cbAction);
            this.Controls.Add(this.label6);
            this.Name = "FormVcard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Видеокарты";
            this.Load += new System.EventHandler(this.FormVcard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtProcFreq;
        private System.Windows.Forms.TextBox txtVidType;
        private System.Windows.Forms.TextBox txtVidCapacity;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.ComboBox cbTable;
        private System.Windows.Forms.ComboBox cbAction;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label9;
    }
}