
namespace Bessonova___Tickets
{
    partial class FormOrganaiser
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
            this.labelAutorization = new System.Windows.Forms.Label();
            this.buttonProf = new System.Windows.Forms.Button();
            this.buttonListof = new System.Windows.Forms.Button();
            this.organaisersTableAdapter1 = new Bessonova___Tickets.DBTicketDataSetTableAdapters.OrganaisersTableAdapter();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(438, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(193, 30);
            this.buttonBack.TabIndex = 29;
            this.buttonBack.Text = "Назад на авторизацию";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelAutorization
            // 
            this.labelAutorization.AutoSize = true;
            this.labelAutorization.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAutorization.Location = new System.Drawing.Point(191, 20);
            this.labelAutorization.Name = "labelAutorization";
            this.labelAutorization.Size = new System.Drawing.Size(193, 22);
            this.labelAutorization.TabIndex = 28;
            this.labelAutorization.Text = "Форма организатора";
            // 
            // buttonProf
            // 
            this.buttonProf.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonProf.Location = new System.Drawing.Point(195, 78);
            this.buttonProf.Name = "buttonProf";
            this.buttonProf.Size = new System.Drawing.Size(193, 30);
            this.buttonProf.TabIndex = 33;
            this.buttonProf.Text = "Просмотреть профиль";
            this.buttonProf.UseVisualStyleBackColor = true;
            this.buttonProf.Click += new System.EventHandler(this.buttonProf_Click);
            // 
            // buttonListof
            // 
            this.buttonListof.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonListof.Location = new System.Drawing.Point(195, 126);
            this.buttonListof.Name = "buttonListof";
            this.buttonListof.Size = new System.Drawing.Size(193, 30);
            this.buttonListof.TabIndex = 34;
            this.buttonListof.Text = "Посмотреть список";
            this.buttonListof.UseVisualStyleBackColor = true;
            this.buttonListof.Click += new System.EventHandler(this.buttonListof_Click);
            // 
            // organaisersTableAdapter1
            // 
            this.organaisersTableAdapter1.ClearBeforeFill = true;
            // 
            // FormOrganaiser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 450);
            this.Controls.Add(this.buttonListof);
            this.Controls.Add(this.buttonProf);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelAutorization);
            this.Name = "FormOrganaiser";
            this.Text = "Билетная система";
            this.Load += new System.EventHandler(this.FormOrganaiser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelAutorization;
        private System.Windows.Forms.Button buttonProf;
        private System.Windows.Forms.Button buttonListof;
        private DBTicketDataSetTableAdapters.OrganaisersTableAdapter organaisersTableAdapter1;
    }
}