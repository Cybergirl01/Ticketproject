
namespace Bessonova___Tickets
{
    partial class FormViewTIcket
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
            this.richTextBoxTicket = new System.Windows.Forms.RichTextBox();
            this.buttonGotoAutorization = new System.Windows.Forms.Button();
            this.buttonQRCode = new System.Windows.Forms.Button();
            this.pictureBoxQR = new System.Windows.Forms.PictureBox();
            this.buttonSaveQRCode = new System.Windows.Forms.Button();
            this.labelViewingticket = new System.Windows.Forms.Label();
            this.clientTableAdapter1 = new Bessonova___Tickets.DBTicketDataSetTableAdapters.ClientTableAdapter();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQR)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBoxTicket
            // 
            this.richTextBoxTicket.Location = new System.Drawing.Point(23, 103);
            this.richTextBoxTicket.Name = "richTextBoxTicket";
            this.richTextBoxTicket.Size = new System.Drawing.Size(608, 390);
            this.richTextBoxTicket.TabIndex = 0;
            this.richTextBoxTicket.Text = "";
            // 
            // buttonGotoAutorization
            // 
            this.buttonGotoAutorization.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGotoAutorization.Location = new System.Drawing.Point(713, 13);
            this.buttonGotoAutorization.Name = "buttonGotoAutorization";
            this.buttonGotoAutorization.Size = new System.Drawing.Size(180, 29);
            this.buttonGotoAutorization.TabIndex = 2;
            this.buttonGotoAutorization.Text = "На авторизацию";
            this.buttonGotoAutorization.UseVisualStyleBackColor = true;
            this.buttonGotoAutorization.Click += new System.EventHandler(this.buttonGotoAutorization_Click);
            // 
            // buttonQRCode
            // 
            this.buttonQRCode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonQRCode.Location = new System.Drawing.Point(23, 68);
            this.buttonQRCode.Name = "buttonQRCode";
            this.buttonQRCode.Size = new System.Drawing.Size(193, 29);
            this.buttonQRCode.TabIndex = 3;
            this.buttonQRCode.Text = "Вывести QR-Код";
            this.buttonQRCode.UseVisualStyleBackColor = true;
            this.buttonQRCode.Click += new System.EventHandler(this.buttonQRCode_Click);
            // 
            // pictureBoxQR
            // 
            this.pictureBoxQR.Location = new System.Drawing.Point(676, 103);
            this.pictureBoxQR.Name = "pictureBoxQR";
            this.pictureBoxQR.Size = new System.Drawing.Size(204, 189);
            this.pictureBoxQR.TabIndex = 4;
            this.pictureBoxQR.TabStop = false;
            // 
            // buttonSaveQRCode
            // 
            this.buttonSaveQRCode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveQRCode.Location = new System.Drawing.Point(687, 312);
            this.buttonSaveQRCode.Name = "buttonSaveQRCode";
            this.buttonSaveQRCode.Size = new System.Drawing.Size(193, 29);
            this.buttonSaveQRCode.TabIndex = 5;
            this.buttonSaveQRCode.Text = "Сохранить QR-Код";
            this.buttonSaveQRCode.UseVisualStyleBackColor = true;
            this.buttonSaveQRCode.Click += new System.EventHandler(this.buttonSaveQRCode_Click);
            // 
            // labelViewingticket
            // 
            this.labelViewingticket.AutoSize = true;
            this.labelViewingticket.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelViewingticket.Location = new System.Drawing.Point(338, 13);
            this.labelViewingticket.Name = "labelViewingticket";
            this.labelViewingticket.Size = new System.Drawing.Size(160, 22);
            this.labelViewingticket.TabIndex = 6;
            this.labelViewingticket.Text = "Просмотр билета";
            // 
            // clientTableAdapter1
            // 
            this.clientTableAdapter1.ClearBeforeFill = true;
            // 
            // buttonPrint
            // 
            this.buttonPrint.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPrint.Location = new System.Drawing.Point(687, 361);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(193, 29);
            this.buttonPrint.TabIndex = 7;
            this.buttonPrint.Text = "Печатать билет";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // FormViewTIcket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 525);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.labelViewingticket);
            this.Controls.Add(this.buttonSaveQRCode);
            this.Controls.Add(this.pictureBoxQR);
            this.Controls.Add(this.buttonQRCode);
            this.Controls.Add(this.buttonGotoAutorization);
            this.Controls.Add(this.richTextBoxTicket);
            this.Name = "FormViewTIcket";
            this.Text = "Билетная система";
            this.Load += new System.EventHandler(this.FormViewTIcketforclient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxTicket;
        private System.Windows.Forms.Button buttonGotoAutorization;
        private System.Windows.Forms.Button buttonQRCode;
        private System.Windows.Forms.PictureBox pictureBoxQR;
        private System.Windows.Forms.Button buttonSaveQRCode;
        private System.Windows.Forms.Label labelViewingticket;
        private DBTicketDataSetTableAdapters.ClientTableAdapter clientTableAdapter1;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}