
namespace Bessonova___Tickets
{
    partial class FormRegWorkers
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
            this.dataGridViewAccounts = new System.Windows.Forms.DataGridView();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonReg = new System.Windows.Forms.Button();
            this.groupBoxWorkeracc = new System.Windows.Forms.GroupBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.comboBoxRoles = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelLog = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.rolesTableAdapter1 = new Bessonova___Tickets.DBTicketDataSetTableAdapters.RolesTableAdapter();
            this.usersTableAdapter1 = new Bessonova___Tickets.DBTicketDataSetTableAdapters.UsersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccounts)).BeginInit();
            this.groupBoxWorkeracc.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewAccounts
            // 
            this.dataGridViewAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAccounts.Location = new System.Drawing.Point(37, 136);
            this.dataGridViewAccounts.Name = "dataGridViewAccounts";
            this.dataGridViewAccounts.Size = new System.Drawing.Size(474, 237);
            this.dataGridViewAccounts.TabIndex = 27;
            this.dataGridViewAccounts.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAccounts_RowEnter);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Font = new System.Drawing.Font("Times New Roman", 12.25F);
            this.buttonInsert.Location = new System.Drawing.Point(572, 401);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(318, 33);
            this.buttonInsert.TabIndex = 26;
            this.buttonInsert.Text = "Внести пользователя в систему";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonReg
            // 
            this.buttonReg.Font = new System.Drawing.Font("Times New Roman", 12.25F);
            this.buttonReg.Location = new System.Drawing.Point(81, 401);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(318, 33);
            this.buttonReg.TabIndex = 25;
            this.buttonReg.Text = "Регистрация пользователя в систему";
            this.buttonReg.UseVisualStyleBackColor = true;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // groupBoxWorkeracc
            // 
            this.groupBoxWorkeracc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxWorkeracc.Controls.Add(this.textBoxPassword);
            this.groupBoxWorkeracc.Controls.Add(this.textBoxLogin);
            this.groupBoxWorkeracc.Controls.Add(this.comboBoxRoles);
            this.groupBoxWorkeracc.Controls.Add(this.label3);
            this.groupBoxWorkeracc.Controls.Add(this.label2);
            this.groupBoxWorkeracc.Controls.Add(this.labelLog);
            this.groupBoxWorkeracc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxWorkeracc.Location = new System.Drawing.Point(544, 136);
            this.groupBoxWorkeracc.Name = "groupBoxWorkeracc";
            this.groupBoxWorkeracc.Size = new System.Drawing.Size(428, 237);
            this.groupBoxWorkeracc.TabIndex = 24;
            this.groupBoxWorkeracc.TabStop = false;
            this.groupBoxWorkeracc.Text = "Данные аккаунта";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(126, 103);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(263, 29);
            this.textBoxPassword.TabIndex = 5;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(126, 54);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(263, 29);
            this.textBoxLogin.TabIndex = 4;
            // 
            // comboBoxRoles
            // 
            this.comboBoxRoles.FormattingEnabled = true;
            this.comboBoxRoles.Location = new System.Drawing.Point(126, 171);
            this.comboBoxRoles.Name = "comboBoxRoles";
            this.comboBoxRoles.Size = new System.Drawing.Size(263, 29);
            this.comboBoxRoles.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Роль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль";
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.Location = new System.Drawing.Point(28, 54);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(61, 21);
            this.labelLog.TabIndex = 0;
            this.labelLog.Text = "Логин";
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(849, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(171, 33);
            this.buttonBack.TabIndex = 28;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // rolesTableAdapter1
            // 
            this.rolesTableAdapter1.ClearBeforeFill = true;
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // FormRegWorkers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 462);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.dataGridViewAccounts);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.buttonReg);
            this.Controls.Add(this.groupBoxWorkeracc);
            this.Name = "FormRegWorkers";
            this.Text = "FormRegWorkers";
            this.Load += new System.EventHandler(this.FormRegWorkers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccounts)).EndInit();
            this.groupBoxWorkeracc.ResumeLayout(false);
            this.groupBoxWorkeracc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAccounts;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.GroupBox groupBoxWorkeracc;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.ComboBox comboBoxRoles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelLog;
        private System.Windows.Forms.Button buttonBack;
        private DBTicketDataSetTableAdapters.RolesTableAdapter rolesTableAdapter1;
        private DBTicketDataSetTableAdapters.UsersTableAdapter usersTableAdapter1;
    }
}