
namespace Bessonova___Tickets
{
    partial class FormRegistrationClients
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
            this.buttonRegister = new System.Windows.Forms.Button();
            this.textBoxPasReg = new System.Windows.Forms.TextBox();
            this.labelInstruction = new System.Windows.Forms.Label();
            this.textBoxLogReg = new System.Windows.Forms.TextBox();
            this.labelPasswordReg = new System.Windows.Forms.Label();
            this.labelLoginReg = new System.Windows.Forms.Label();
            this.labelAutorization = new System.Windows.Forms.Label();
            this.checkBoxShowPass = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(664, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(133, 30);
            this.buttonBack.TabIndex = 17;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonRegister
            // 
            this.buttonRegister.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegister.Location = new System.Drawing.Point(318, 269);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(168, 30);
            this.buttonRegister.TabIndex = 16;
            this.buttonRegister.Text = "Зарегистрироваться";
            this.buttonRegister.UseVisualStyleBackColor = true;
            // 
            // textBoxPasReg
            // 
            this.textBoxPasReg.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPasReg.Location = new System.Drawing.Point(260, 206);
            this.textBoxPasReg.Name = "textBoxPasReg";
            this.textBoxPasReg.PasswordChar = '*';
            this.textBoxPasReg.Size = new System.Drawing.Size(287, 29);
            this.textBoxPasReg.TabIndex = 14;
            // 
            // labelInstruction
            // 
            this.labelInstruction.AutoSize = true;
            this.labelInstruction.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInstruction.Location = new System.Drawing.Point(91, 69);
            this.labelInstruction.Name = "labelInstruction";
            this.labelInstruction.Size = new System.Drawing.Size(621, 42);
            this.labelInstruction.TabIndex = 13;
            this.labelInstruction.Text = "Введите адрес электронной почты в качестве логина и придумайте пароль, \r\nчтобы за" +
    "регистрироваться в систему.";
            this.labelInstruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxLogReg
            // 
            this.textBoxLogReg.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogReg.Location = new System.Drawing.Point(260, 158);
            this.textBoxLogReg.Name = "textBoxLogReg";
            this.textBoxLogReg.Size = new System.Drawing.Size(287, 29);
            this.textBoxLogReg.TabIndex = 12;
            // 
            // labelPasswordReg
            // 
            this.labelPasswordReg.AutoSize = true;
            this.labelPasswordReg.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPasswordReg.Location = new System.Drawing.Point(166, 209);
            this.labelPasswordReg.Name = "labelPasswordReg";
            this.labelPasswordReg.Size = new System.Drawing.Size(69, 21);
            this.labelPasswordReg.TabIndex = 11;
            this.labelPasswordReg.Text = "Пароль";
            // 
            // labelLoginReg
            // 
            this.labelLoginReg.AutoSize = true;
            this.labelLoginReg.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLoginReg.Location = new System.Drawing.Point(166, 166);
            this.labelLoginReg.Name = "labelLoginReg";
            this.labelLoginReg.Size = new System.Drawing.Size(61, 21);
            this.labelLoginReg.TabIndex = 10;
            this.labelLoginReg.Text = "Логин";
            // 
            // labelAutorization
            // 
            this.labelAutorization.AutoSize = true;
            this.labelAutorization.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAutorization.Location = new System.Drawing.Point(355, 33);
            this.labelAutorization.Name = "labelAutorization";
            this.labelAutorization.Size = new System.Drawing.Size(121, 22);
            this.labelAutorization.TabIndex = 9;
            this.labelAutorization.Text = "Регистрация";
            // 
            // checkBoxShowPass
            // 
            this.checkBoxShowPass.AutoSize = true;
            this.checkBoxShowPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxShowPass.Location = new System.Drawing.Point(563, 209);
            this.checkBoxShowPass.Name = "checkBoxShowPass";
            this.checkBoxShowPass.Size = new System.Drawing.Size(88, 23);
            this.checkBoxShowPass.TabIndex = 18;
            this.checkBoxShowPass.Text = "Показать";
            this.checkBoxShowPass.UseVisualStyleBackColor = true;
            this.checkBoxShowPass.CheckedChanged += new System.EventHandler(this.checkBoxShowPass_CheckedChanged);
            // 
            // FormRegistrationClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 346);
            this.Controls.Add(this.checkBoxShowPass);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.textBoxPasReg);
            this.Controls.Add(this.labelInstruction);
            this.Controls.Add(this.textBoxLogReg);
            this.Controls.Add(this.labelPasswordReg);
            this.Controls.Add(this.labelLoginReg);
            this.Controls.Add(this.labelAutorization);
            this.Name = "FormRegistrationClients";
            this.Text = "Билетная система";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox textBoxPasReg;
        private System.Windows.Forms.Label labelInstruction;
        private System.Windows.Forms.TextBox textBoxLogReg;
        private System.Windows.Forms.Label labelPasswordReg;
        private System.Windows.Forms.Label labelLoginReg;
        private System.Windows.Forms.Label labelAutorization;
        private System.Windows.Forms.CheckBox checkBoxShowPass;
    }
}