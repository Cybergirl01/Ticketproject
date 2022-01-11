
namespace Bessonova___Tickets
{
    partial class FormClient
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
            this.buttonTickets = new System.Windows.Forms.Button();
            this.buttonBuyticket = new System.Windows.Forms.Button();
            this.clientProfileTableAdapter1 = new Bessonova___Tickets.DBTicketDataSetTableAdapters.ClientProfTableAdapter();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(395, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(193, 30);
            this.buttonBack.TabIndex = 27;
            this.buttonBack.Text = "Назад на авторизацию";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelAutorization
            // 
            this.labelAutorization.AutoSize = true;
            this.labelAutorization.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAutorization.Location = new System.Drawing.Point(205, 16);
            this.labelAutorization.Name = "labelAutorization";
            this.labelAutorization.Size = new System.Drawing.Size(147, 22);
            this.labelAutorization.TabIndex = 26;
            this.labelAutorization.Text = "Форма клиента";
            // 
            // buttonProf
            // 
            this.buttonProf.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonProf.Location = new System.Drawing.Point(178, 115);
            this.buttonProf.Name = "buttonProf";
            this.buttonProf.Size = new System.Drawing.Size(193, 30);
            this.buttonProf.TabIndex = 28;
            this.buttonProf.Text = "Просмотреть профиль";
            this.buttonProf.UseVisualStyleBackColor = true;
            this.buttonProf.Click += new System.EventHandler(this.buttonProf_Click);
            // 
            // buttonTickets
            // 
            this.buttonTickets.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTickets.Location = new System.Drawing.Point(178, 179);
            this.buttonTickets.Name = "buttonTickets";
            this.buttonTickets.Size = new System.Drawing.Size(193, 30);
            this.buttonTickets.TabIndex = 29;
            this.buttonTickets.Text = "Мои билеты";
            this.buttonTickets.UseVisualStyleBackColor = true;
            this.buttonTickets.Click += new System.EventHandler(this.buttonTickets_Click);
            // 
            // buttonBuyticket
            // 
            this.buttonBuyticket.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBuyticket.Location = new System.Drawing.Point(178, 239);
            this.buttonBuyticket.Name = "buttonBuyticket";
            this.buttonBuyticket.Size = new System.Drawing.Size(193, 30);
            this.buttonBuyticket.TabIndex = 30;
            this.buttonBuyticket.Text = "Купить билет";
            this.buttonBuyticket.UseVisualStyleBackColor = true;
            this.buttonBuyticket.Click += new System.EventHandler(this.buttonBuyticket_Click);
            // 
            // clientProfileTableAdapter1
            // 
            this.clientProfileTableAdapter1.ClearBeforeFill = true;
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 450);
            this.Controls.Add(this.buttonBuyticket);
            this.Controls.Add(this.buttonTickets);
            this.Controls.Add(this.buttonProf);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelAutorization);
            this.Name = "FormClient";
            this.Text = "Билетная система";
            this.Load += new System.EventHandler(this.FormClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelAutorization;
        private System.Windows.Forms.Button buttonProf;
        private System.Windows.Forms.Button buttonTickets;
        private System.Windows.Forms.Button buttonBuyticket;
        private DBTicketDataSetTableAdapters.ClientProfTableAdapter clientProfileTableAdapter1;
    }
}