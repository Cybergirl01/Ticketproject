
namespace Bessonova___Tickets
{
    partial class FormAdmin
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
            this.labelAdmin = new System.Windows.Forms.Label();
            this.buttonGotoHIstory = new System.Windows.Forms.Button();
            this.buttonRegWorkers = new System.Windows.Forms.Button();
            this.buttonListUsers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(595, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(193, 30);
            this.buttonBack.TabIndex = 29;
            this.buttonBack.Text = "Назад на авторизацию";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelAdmin
            // 
            this.labelAdmin.AutoSize = true;
            this.labelAdmin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdmin.Location = new System.Drawing.Point(283, 20);
            this.labelAdmin.Name = "labelAdmin";
            this.labelAdmin.Size = new System.Drawing.Size(218, 22);
            this.labelAdmin.TabIndex = 28;
            this.labelAdmin.Text = "Форма администратора";
            // 
            // buttonGotoHIstory
            // 
            this.buttonGotoHIstory.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGotoHIstory.Location = new System.Drawing.Point(279, 77);
            this.buttonGotoHIstory.Name = "buttonGotoHIstory";
            this.buttonGotoHIstory.Size = new System.Drawing.Size(242, 30);
            this.buttonGotoHIstory.TabIndex = 30;
            this.buttonGotoHIstory.Text = "Просмотреть историю действий Просмотреть историю действий Просмотреть историю дей" +
    "ствий ";
            this.buttonGotoHIstory.UseVisualStyleBackColor = true;
            // 
            // buttonRegWorkers
            // 
            this.buttonRegWorkers.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegWorkers.Location = new System.Drawing.Point(279, 136);
            this.buttonRegWorkers.Name = "buttonRegWorkers";
            this.buttonRegWorkers.Size = new System.Drawing.Size(242, 30);
            this.buttonRegWorkers.TabIndex = 31;
            this.buttonRegWorkers.Text = "Регистрация рабочих";
            this.buttonRegWorkers.UseVisualStyleBackColor = true;
            this.buttonRegWorkers.Click += new System.EventHandler(this.buttonRegWorkers_Click);
            // 
            // buttonListUsers
            // 
            this.buttonListUsers.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonListUsers.Location = new System.Drawing.Point(279, 194);
            this.buttonListUsers.Name = "buttonListUsers";
            this.buttonListUsers.Size = new System.Drawing.Size(242, 30);
            this.buttonListUsers.TabIndex = 32;
            this.buttonListUsers.Text = "Список пользователей";
            this.buttonListUsers.UseVisualStyleBackColor = true;
            this.buttonListUsers.Click += new System.EventHandler(this.buttonListUsers_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonListUsers);
            this.Controls.Add(this.buttonRegWorkers);
            this.Controls.Add(this.buttonGotoHIstory);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelAdmin);
            this.Name = "FormAdmin";
            this.Text = "Билетная система";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelAdmin;
        private System.Windows.Forms.Button buttonGotoHIstory;
        private System.Windows.Forms.Button buttonRegWorkers;
        private System.Windows.Forms.Button buttonListUsers;
    }
}