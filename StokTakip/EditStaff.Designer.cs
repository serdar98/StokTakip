namespace StokTakip
{
    partial class frmStaff
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
            this.dgvListStaff = new System.Windows.Forms.DataGridView();
            this.StaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffTelephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStaff = new System.Windows.Forms.MenuStrip();
            this.productToolMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblUserType = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUserType = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStaffSalary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStaffTelephone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStaffGender = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStaffSurname = new System.Windows.Forms.TextBox();
            this.btnDeleteStaff = new System.Windows.Forms.Button();
            this.btnCancelStaff = new System.Windows.Forms.Button();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.pnlStaff = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListStaff)).BeginInit();
            this.menuStaff.SuspendLayout();
            this.pnlStaff.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListStaff
            // 
            this.dgvListStaff.AllowUserToDeleteRows = false;
            this.dgvListStaff.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvListStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StaffID,
            this.StaffName,
            this.StaffSurname,
            this.StaffGender,
            this.StaffTelephone,
            this.StaffSalary});
            this.dgvListStaff.GridColor = System.Drawing.SystemColors.Window;
            this.dgvListStaff.Location = new System.Drawing.Point(655, 51);
            this.dgvListStaff.Name = "dgvListStaff";
            this.dgvListStaff.ReadOnly = true;
            this.dgvListStaff.RowHeadersWidth = 51;
            this.dgvListStaff.RowTemplate.Height = 24;
            this.dgvListStaff.Size = new System.Drawing.Size(589, 547);
            this.dgvListStaff.TabIndex = 13;
            this.dgvListStaff.DoubleClick += new System.EventHandler(this.dgvListStaff_DoubleClick);
            // 
            // StaffID
            // 
            this.StaffID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StaffID.DataPropertyName = "staffID";
            this.StaffID.HeaderText = "Staff ID";
            this.StaffID.MinimumWidth = 6;
            this.StaffID.Name = "StaffID";
            this.StaffID.ReadOnly = true;
            this.StaffID.Visible = false;
            // 
            // StaffName
            // 
            this.StaffName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StaffName.DataPropertyName = "StaffName";
            this.StaffName.HeaderText = "Ad";
            this.StaffName.MinimumWidth = 6;
            this.StaffName.Name = "StaffName";
            this.StaffName.ReadOnly = true;
            // 
            // StaffSurname
            // 
            this.StaffSurname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StaffSurname.DataPropertyName = "StaffSurname";
            this.StaffSurname.HeaderText = "Soyad";
            this.StaffSurname.MinimumWidth = 6;
            this.StaffSurname.Name = "StaffSurname";
            this.StaffSurname.ReadOnly = true;
            // 
            // StaffGender
            // 
            this.StaffGender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StaffGender.DataPropertyName = "StaffGender";
            this.StaffGender.HeaderText = "Cinsiyet";
            this.StaffGender.MinimumWidth = 6;
            this.StaffGender.Name = "StaffGender";
            this.StaffGender.ReadOnly = true;
            // 
            // StaffTelephone
            // 
            this.StaffTelephone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StaffTelephone.DataPropertyName = "StaffTelephone";
            this.StaffTelephone.HeaderText = "Telefon";
            this.StaffTelephone.MinimumWidth = 6;
            this.StaffTelephone.Name = "StaffTelephone";
            this.StaffTelephone.ReadOnly = true;
            // 
            // StaffSalary
            // 
            this.StaffSalary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StaffSalary.DataPropertyName = "StaffSalary";
            this.StaffSalary.HeaderText = "Maaş";
            this.StaffSalary.MinimumWidth = 6;
            this.StaffSalary.Name = "StaffSalary";
            this.StaffSalary.ReadOnly = true;
            // 
            // menuStaff
            // 
            this.menuStaff.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStaff.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productToolMenu});
            this.menuStaff.Location = new System.Drawing.Point(0, 0);
            this.menuStaff.Name = "menuStaff";
            this.menuStaff.Size = new System.Drawing.Size(1266, 40);
            this.menuStaff.TabIndex = 14;
            this.menuStaff.Text = "menuStaff";
            // 
            // productToolMenu
            // 
            this.productToolMenu.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.productToolMenu.Name = "productToolMenu";
            this.productToolMenu.Size = new System.Drawing.Size(261, 36);
            this.productToolMenu.Text = "Ürünler Sayfasına Geç";
            this.productToolMenu.Click += new System.EventHandler(this.productToolMenu_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.Location = new System.Drawing.Point(1050, 701);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(180, 60);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "Çıkış";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserType.Location = new System.Drawing.Point(874, 653);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(152, 29);
            this.lblUserType.TabIndex = 30;
            this.lblUserType.Text = "Kullanıcı Tipi";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUser.Location = new System.Drawing.Point(874, 604);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(145, 29);
            this.lblUser.TabIndex = 29;
            this.lblUser.Text = "Kullanıcı Adı";
            // 
            // txtUserType
            // 
            this.txtUserType.BackColor = System.Drawing.SystemColors.Window;
            this.txtUserType.Enabled = false;
            this.txtUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUserType.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtUserType.Location = new System.Drawing.Point(1032, 650);
            this.txtUserType.Multiline = true;
            this.txtUserType.Name = "txtUserType";
            this.txtUserType.Size = new System.Drawing.Size(198, 40);
            this.txtUserType.TabIndex = 28;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.SystemColors.Window;
            this.txtUser.Enabled = false;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUser.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtUser.Location = new System.Drawing.Point(1032, 604);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(198, 40);
            this.txtUser.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(27, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 29);
            this.label1.TabIndex = 22;
            this.label1.Text = "Personel Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(27, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 29);
            this.label2.TabIndex = 23;
            this.label2.Text = "Personel Soyad";
            // 
            // txtStaffSalary
            // 
            this.txtStaffSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStaffSalary.ForeColor = System.Drawing.Color.Black;
            this.txtStaffSalary.Location = new System.Drawing.Point(276, 225);
            this.txtStaffSalary.Multiline = true;
            this.txtStaffSalary.Name = "txtStaffSalary";
            this.txtStaffSalary.Size = new System.Drawing.Size(315, 41);
            this.txtStaffSalary.TabIndex = 20;
            this.txtStaffSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberControl);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(27, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 29);
            this.label4.TabIndex = 24;
            this.label4.Text = "Personel Cinsiyet";
            // 
            // txtStaffTelephone
            // 
            this.txtStaffTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStaffTelephone.ForeColor = System.Drawing.Color.Black;
            this.txtStaffTelephone.Location = new System.Drawing.Point(276, 178);
            this.txtStaffTelephone.Multiline = true;
            this.txtStaffTelephone.Name = "txtStaffTelephone";
            this.txtStaffTelephone.Size = new System.Drawing.Size(315, 41);
            this.txtStaffTelephone.TabIndex = 18;
            this.txtStaffTelephone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberControl);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(27, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 29);
            this.label3.TabIndex = 25;
            this.label3.Text = "Personel Telefon";
            // 
            // txtStaffGender
            // 
            this.txtStaffGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStaffGender.ForeColor = System.Drawing.Color.Black;
            this.txtStaffGender.Location = new System.Drawing.Point(276, 131);
            this.txtStaffGender.Multiline = true;
            this.txtStaffGender.Name = "txtStaffGender";
            this.txtStaffGender.Size = new System.Drawing.Size(315, 41);
            this.txtStaffGender.TabIndex = 17;
            this.txtStaffGender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CharControl);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(27, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 29);
            this.label5.TabIndex = 26;
            this.label5.Text = "Personel Maaş";
            // 
            // txtStaffSurname
            // 
            this.txtStaffSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStaffSurname.ForeColor = System.Drawing.Color.Black;
            this.txtStaffSurname.Location = new System.Drawing.Point(276, 84);
            this.txtStaffSurname.Multiline = true;
            this.txtStaffSurname.Name = "txtStaffSurname";
            this.txtStaffSurname.Size = new System.Drawing.Size(315, 41);
            this.txtStaffSurname.TabIndex = 16;
            this.txtStaffSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CharControl);
            // 
            // btnDeleteStaff
            // 
            this.btnDeleteStaff.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDeleteStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteStaff.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteStaff.Location = new System.Drawing.Point(303, 324);
            this.btnDeleteStaff.Name = "btnDeleteStaff";
            this.btnDeleteStaff.Size = new System.Drawing.Size(141, 60);
            this.btnDeleteStaff.TabIndex = 12;
            this.btnDeleteStaff.Text = "Personel Sil";
            this.btnDeleteStaff.UseVisualStyleBackColor = false;
            this.btnDeleteStaff.Click += new System.EventHandler(this.btnDeleteStaff_Click);
            // 
            // btnCancelStaff
            // 
            this.btnCancelStaff.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancelStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCancelStaff.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelStaff.Location = new System.Drawing.Point(450, 324);
            this.btnCancelStaff.Name = "btnCancelStaff";
            this.btnCancelStaff.Size = new System.Drawing.Size(141, 60);
            this.btnCancelStaff.TabIndex = 11;
            this.btnCancelStaff.Text = "Temizle";
            this.btnCancelStaff.UseVisualStyleBackColor = false;
            this.btnCancelStaff.Click += new System.EventHandler(this.btnCancelStaff_Click);
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddStaff.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddStaff.Location = new System.Drawing.Point(156, 324);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(141, 60);
            this.btnAddStaff.TabIndex = 10;
            this.btnAddStaff.Text = "Personel Ekle";
            this.btnAddStaff.UseVisualStyleBackColor = false;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // txtStaffName
            // 
            this.txtStaffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStaffName.ForeColor = System.Drawing.Color.Black;
            this.txtStaffName.Location = new System.Drawing.Point(276, 37);
            this.txtStaffName.Multiline = true;
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(315, 41);
            this.txtStaffName.TabIndex = 15;
            this.txtStaffName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CharControl);
            // 
            // pnlStaff
            // 
            this.pnlStaff.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlStaff.Controls.Add(this.txtStaffName);
            this.pnlStaff.Controls.Add(this.btnAddStaff);
            this.pnlStaff.Controls.Add(this.btnCancelStaff);
            this.pnlStaff.Controls.Add(this.btnDeleteStaff);
            this.pnlStaff.Controls.Add(this.txtStaffSurname);
            this.pnlStaff.Controls.Add(this.label5);
            this.pnlStaff.Controls.Add(this.txtStaffGender);
            this.pnlStaff.Controls.Add(this.label3);
            this.pnlStaff.Controls.Add(this.txtStaffTelephone);
            this.pnlStaff.Controls.Add(this.label4);
            this.pnlStaff.Controls.Add(this.txtStaffSalary);
            this.pnlStaff.Controls.Add(this.label2);
            this.pnlStaff.Controls.Add(this.label1);
            this.pnlStaff.Location = new System.Drawing.Point(27, 51);
            this.pnlStaff.Name = "pnlStaff";
            this.pnlStaff.Size = new System.Drawing.Size(608, 547);
            this.pnlStaff.TabIndex = 31;
            this.pnlStaff.Visible = false;
            // 
            // frmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1266, 773);
            this.Controls.Add(this.pnlStaff);
            this.Controls.Add(this.lblUserType);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvListStaff);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.menuStaff);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtUserType);
            this.Name = "frmStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personeller";
            this.Load += new System.EventHandler(this.frmStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListStaff)).EndInit();
            this.menuStaff.ResumeLayout(false);
            this.menuStaff.PerformLayout();
            this.pnlStaff.ResumeLayout(false);
            this.pnlStaff.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStaff;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolStripMenuItem productToolMenu;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffTelephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffSalary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DataGridView dgvListStaff;
        public System.Windows.Forms.TextBox txtUserType;
        public System.Windows.Forms.TextBox txtUser;
        public System.Windows.Forms.TextBox txtStaffSalary;
        public System.Windows.Forms.TextBox txtStaffTelephone;
        public System.Windows.Forms.TextBox txtStaffGender;
        public System.Windows.Forms.TextBox txtStaffSurname;
        public System.Windows.Forms.Button btnDeleteStaff;
        public System.Windows.Forms.Button btnCancelStaff;
        public System.Windows.Forms.Button btnAddStaff;
        public System.Windows.Forms.TextBox txtStaffName;
        public System.Windows.Forms.Panel pnlStaff;
    }
}