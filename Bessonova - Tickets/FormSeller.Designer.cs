
namespace Bessonova___Tickets
{
    partial class FormSeller
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
            this.buttonGotosellTicket = new System.Windows.Forms.Button();
            this.sellerTableAdapter1 = new Bessonova___Tickets.DBTicketDataSetTableAdapters.SellerTableAdapter();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(439, 12);
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
            this.labelAutorization.Location = new System.Drawing.Point(227, 20);
            this.labelAutorization.Name = "labelAutorization";
            this.labelAutorization.Size = new System.Drawing.Size(156, 22);
            this.labelAutorization.TabIndex = 28;
            this.labelAutorization.Text = "Форма продавца";
            // 
            // buttonProf
            // 
            this.buttonProf.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonProf.Location = new System.Drawing.Point(205, 107);
            this.buttonProf.Name = "buttonProf";
            this.buttonProf.Size = new System.Drawing.Size(193, 30);
            this.buttonProf.TabIndex = 32;
            this.buttonProf.Text = "Просмотреть профиль";
            this.buttonProf.UseVisualStyleBackColor = true;
            this.buttonProf.Click += new System.EventHandler(this.buttonProf_Click);
            // 
            // buttonGotosellTicket
            // 
            this.buttonGotosellTicket.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGotosellTicket.Location = new System.Drawing.Point(205, 167);
            this.buttonGotosellTicket.Name = "buttonGotosellTicket";
            this.buttonGotosellTicket.Size = new System.Drawing.Size(193, 30);
            this.buttonGotosellTicket.TabIndex = 33;
            this.buttonGotosellTicket.Text = "Продать билет";
            this.buttonGotosellTicket.UseVisualStyleBackColor = true;
            this.buttonGotosellTicket.Click += new System.EventHandler(this.buttonGotosellTicket_Click);
            // 
            // sellerTableAdapter1
            // 
            this.sellerTableAdapter1.ClearBeforeFill = true;
            // 
            // FormSeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 450);
            this.Controls.Add(this.buttonGotosellTicket);
            this.Controls.Add(this.buttonProf);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelAutorization);
            this.Name = "FormSeller";
            this.Text = "Билетная система";
            this.Load += new System.EventHandler(this.FormSeller_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelAutorization;
        private System.Windows.Forms.Button buttonProf;
        private System.Windows.Forms.Button buttonGotosellTicket;
        private DBTicketDataSetTableAdapters.SellerTableAdapter sellerTableAdapter1;
    }
}