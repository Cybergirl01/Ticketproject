
namespace Bessonova___Tickets
{
    partial class FormCreateNewPassword
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.textBoxPasConfirm = new System.Windows.Forms.TextBox();
            this.labelInstruction = new System.Windows.Forms.Label();
            this.textBoxNewPas = new System.Windows.Forms.TextBox();
            this.labelPasswordReg = new System.Windows.Forms.Label();
            this.labelLoginReg = new System.Windows.Forms.Label();
            this.labelAutorization = new System.Windows.Forms.Label();
            this.checkBoxShowPass = new System.Windows.Forms.CheckBox();
            this.checkBoxShowPas2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(655, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(133, 30);
            this.buttonBack.TabIndex = 25;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonConfirm.Location = new System.Drawing.Point(321, 256);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(168, 30);
            this.buttonConfirm.TabIndex = 24;
            this.buttonConfirm.Text = "Подтвердить";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // textBoxPasConfirm
            // 
            this.textBoxPasConfirm.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPasConfirm.Location = new System.Drawing.Point(258, 192);
            this.textBoxPasConfirm.Name = "textBoxPasConfirm";
            this.textBoxPasConfirm.PasswordChar = '*';
            this.textBoxPasConfirm.Size = new System.Drawing.Size(287, 29);
            this.textBoxPasConfirm.TabIndex = 23;
            // 
            // labelInstruction
            // 
            this.labelInstruction.AutoSize = true;
            this.labelInstruction.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInstruction.Location = new System.Drawing.Point(114, 88);
            this.labelInstruction.Name = "labelInstruction";
            this.labelInstruction.Size = new System.Drawing.Size(548, 21);
            this.labelInstruction.TabIndex = 22;
            this.labelInstruction.Text = "Придумайте и введите новый пароль для восстановления доступа.";
            this.labelInstruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxNewPas
            // 
            this.textBoxNewPas.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNewPas.Location = new System.Drawing.Point(258, 144);
            this.textBoxNewPas.Name = "textBoxNewPas";
            this.textBoxNewPas.PasswordChar = '*';
            this.textBoxNewPas.Size = new System.Drawing.Size(287, 29);
            this.textBoxNewPas.TabIndex = 21;
            // 
            // labelPasswordReg
            // 
            this.labelPasswordReg.AutoSize = true;
            this.labelPasswordReg.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPasswordReg.Location = new System.Drawing.Point(55, 195);
            this.labelPasswordReg.Name = "labelPasswordReg";
            this.labelPasswordReg.Size = new System.Drawing.Size(197, 21);
            this.labelPasswordReg.TabIndex = 20;
            this.labelPasswordReg.Text = "Подтверждение пароля";
            // 
            // labelLoginReg
            // 
            this.labelLoginReg.AutoSize = true;
            this.labelLoginReg.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLoginReg.Location = new System.Drawing.Point(126, 147);
            this.labelLoginReg.Name = "labelLoginReg";
            this.labelLoginReg.Size = new System.Drawing.Size(126, 21);
            this.labelLoginReg.TabIndex = 19;
            this.labelLoginReg.Text = "Новый пароль";
            // 
            // labelAutorization
            // 
            this.labelAutorization.AutoSize = true;
            this.labelAutorization.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAutorization.Location = new System.Drawing.Point(282, 43);
            this.labelAutorization.Name = "labelAutorization";
            this.labelAutorization.Size = new System.Drawing.Size(219, 22);
            this.labelAutorization.TabIndex = 18;
            this.labelAutorization.Text = "Восстановление пароля";
            // 
            // checkBoxShowPass
            // 
            this.checkBoxShowPass.AutoSize = true;
            this.checkBoxShowPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxShowPass.Location = new System.Drawing.Point(551, 147);
            this.checkBoxShowPass.Name = "checkBoxShowPass";
            this.checkBoxShowPass.Size = new System.Drawing.Size(88, 23);
            this.checkBoxShowPass.TabIndex = 26;
            this.checkBoxShowPass.Text = "Показать";
            this.checkBoxShowPass.UseVisualStyleBackColor = true;
            this.checkBoxShowPass.CheckedChanged += new System.EventHandler(this.checkBoxShowPass_CheckedChanged);
            // 
            // checkBoxShowPas2
            // 
            this.checkBoxShowPas2.AutoSize = true;
            this.checkBoxShowPas2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxShowPas2.Location = new System.Drawing.Point(551, 198);
            this.checkBoxShowPas2.Name = "checkBoxShowPas2";
            this.checkBoxShowPas2.Size = new System.Drawing.Size(88, 23);
            this.checkBoxShowPas2.TabIndex = 27;
            this.checkBoxShowPas2.Text = "Показать";
            this.checkBoxShowPas2.UseVisualStyleBackColor = true;
            this.checkBoxShowPas2.CheckedChanged += new System.EventHandler(this.checkBoxShowPas2_CheckedChanged);
            // 
            // FormCreateNewPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 317);
            this.Controls.Add(this.checkBoxShowPas2);
            this.Controls.Add(this.checkBoxShowPass);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.textBoxPasConfirm);
            this.Controls.Add(this.labelInstruction);
            this.Controls.Add(this.textBoxNewPas);
            this.Controls.Add(this.labelPasswordReg);
            this.Controls.Add(this.labelLoginReg);
            this.Controls.Add(this.labelAutorization);
            this.Name = "FormCreateNewPassword";
            this.Text = "Билетная система";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.TextBox textBoxPasConfirm;
        private System.Windows.Forms.Label labelInstruction;
        private System.Windows.Forms.TextBox textBoxNewPas;
        private System.Windows.Forms.Label labelPasswordReg;
        private System.Windows.Forms.Label labelLoginReg;
        private System.Windows.Forms.Label labelAutorization;
        private System.Windows.Forms.CheckBox checkBoxShowPass;
        private System.Windows.Forms.CheckBox checkBoxShowPas2;
    }
}