
namespace Bessonova___Tickets
{
    partial class FormBuyingTicketsIceSkate
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
            this.buttonViewTicket = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelBuyFilm = new System.Windows.Forms.Label();
            this.numericUpDownRad = new System.Windows.Forms.NumericUpDown();
            this.labelRad = new System.Windows.Forms.Label();
            this.numericUpDownPlace = new System.Windows.Forms.NumericUpDown();
            this.labelMesto = new System.Windows.Forms.Label();
            this.numericUpDownZal = new System.Windows.Forms.NumericUpDown();
            this.labelZal = new System.Windows.Forms.Label();
            this.labelEventname = new System.Windows.Forms.Label();
            this.comboBoxIcebuy = new System.Windows.Forms.ComboBox();
            this.buttonBuyTicket = new System.Windows.Forms.Button();
            this.ticketClientTableAdapter1 = new Bessonova___Tickets.DBTicketDataSetTableAdapters.TicketClientTableAdapter();
            this.labelViewtime = new System.Windows.Forms.Label();
            this.comboBoxTimeview = new System.Windows.Forms.ComboBox();
            this.labelSum = new System.Windows.Forms.Label();
            this.labelItog = new System.Windows.Forms.Label();
            this.clientTableAdapter1 = new Bessonova___Tickets.DBTicketDataSetTableAdapters.ClientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZal)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonViewTicket
            // 
            this.buttonViewTicket.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonViewTicket.Location = new System.Drawing.Point(12, 409);
            this.buttonViewTicket.Name = "buttonViewTicket";
            this.buttonViewTicket.Size = new System.Drawing.Size(193, 28);
            this.buttonViewTicket.TabIndex = 75;
            this.buttonViewTicket.Text = "Просмотреть билет";
            this.buttonViewTicket.UseVisualStyleBackColor = true;
            this.buttonViewTicket.Click += new System.EventHandler(this.buttonViewTicket_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(595, 14);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(193, 30);
            this.buttonBack.TabIndex = 74;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelBuyFilm
            // 
            this.labelBuyFilm.AutoSize = true;
            this.labelBuyFilm.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBuyFilm.Location = new System.Drawing.Point(303, 18);
            this.labelBuyFilm.Name = "labelBuyFilm";
            this.labelBuyFilm.Size = new System.Drawing.Size(156, 22);
            this.labelBuyFilm.TabIndex = 73;
            this.labelBuyFilm.Text = "Покупка билета ";
            // 
            // numericUpDownRad
            // 
            this.numericUpDownRad.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownRad.Location = new System.Drawing.Point(595, 92);
            this.numericUpDownRad.Name = "numericUpDownRad";
            this.numericUpDownRad.Size = new System.Drawing.Size(120, 29);
            this.numericUpDownRad.TabIndex = 72;
            this.numericUpDownRad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelRad
            // 
            this.labelRad.AutoSize = true;
            this.labelRad.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRad.Location = new System.Drawing.Point(525, 100);
            this.labelRad.Name = "labelRad";
            this.labelRad.Size = new System.Drawing.Size(39, 21);
            this.labelRad.TabIndex = 71;
            this.labelRad.Text = "Ряд";
            // 
            // numericUpDownPlace
            // 
            this.numericUpDownPlace.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownPlace.Location = new System.Drawing.Point(595, 150);
            this.numericUpDownPlace.Name = "numericUpDownPlace";
            this.numericUpDownPlace.Size = new System.Drawing.Size(120, 29);
            this.numericUpDownPlace.TabIndex = 70;
            this.numericUpDownPlace.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelMesto
            // 
            this.labelMesto.AutoSize = true;
            this.labelMesto.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMesto.Location = new System.Drawing.Point(525, 158);
            this.labelMesto.Name = "labelMesto";
            this.labelMesto.Size = new System.Drawing.Size(61, 21);
            this.labelMesto.TabIndex = 69;
            this.labelMesto.Text = "Место";
            // 
            // numericUpDownZal
            // 
            this.numericUpDownZal.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownZal.Location = new System.Drawing.Point(97, 150);
            this.numericUpDownZal.Name = "numericUpDownZal";
            this.numericUpDownZal.Size = new System.Drawing.Size(120, 29);
            this.numericUpDownZal.TabIndex = 68;
            this.numericUpDownZal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelZal
            // 
            this.labelZal.AutoSize = true;
            this.labelZal.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelZal.Location = new System.Drawing.Point(27, 158);
            this.labelZal.Name = "labelZal";
            this.labelZal.Size = new System.Drawing.Size(37, 21);
            this.labelZal.TabIndex = 67;
            this.labelZal.Text = "Зал";
            // 
            // labelEventname
            // 
            this.labelEventname.AutoSize = true;
            this.labelEventname.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEventname.Location = new System.Drawing.Point(24, 93);
            this.labelEventname.Name = "labelEventname";
            this.labelEventname.Size = new System.Drawing.Size(84, 21);
            this.labelEventname.TabIndex = 66;
            this.labelEventname.Text = "Название";
            // 
            // comboBoxIcebuy
            // 
            this.comboBoxIcebuy.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxIcebuy.FormattingEnabled = true;
            this.comboBoxIcebuy.Location = new System.Drawing.Point(125, 92);
            this.comboBoxIcebuy.Name = "comboBoxIcebuy";
            this.comboBoxIcebuy.Size = new System.Drawing.Size(201, 29);
            this.comboBoxIcebuy.TabIndex = 65;
            this.comboBoxIcebuy.SelectedIndexChanged += new System.EventHandler(this.comboBoxIcebuy_SelectedIndexChanged);
            // 
            // buttonBuyTicket
            // 
            this.buttonBuyTicket.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBuyTicket.Location = new System.Drawing.Point(595, 406);
            this.buttonBuyTicket.Name = "buttonBuyTicket";
            this.buttonBuyTicket.Size = new System.Drawing.Size(193, 28);
            this.buttonBuyTicket.TabIndex = 64;
            this.buttonBuyTicket.Text = "Купить билет";
            this.buttonBuyTicket.UseVisualStyleBackColor = true;
            this.buttonBuyTicket.Click += new System.EventHandler(this.buttonBuyTicket_Click);
            // 
            // ticketClientTableAdapter1
            // 
            this.ticketClientTableAdapter1.ClearBeforeFill = true;
            // 
            // labelViewtime
            // 
            this.labelViewtime.AutoSize = true;
            this.labelViewtime.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelViewtime.Location = new System.Drawing.Point(27, 208);
            this.labelViewtime.Name = "labelViewtime";
            this.labelViewtime.Size = new System.Drawing.Size(153, 21);
            this.labelViewtime.TabIndex = 77;
            this.labelViewtime.Text = "Время просмотра";
            // 
            // comboBoxTimeview
            // 
            this.comboBoxTimeview.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxTimeview.FormattingEnabled = true;
            this.comboBoxTimeview.Location = new System.Drawing.Point(186, 205);
            this.comboBoxTimeview.Name = "comboBoxTimeview";
            this.comboBoxTimeview.Size = new System.Drawing.Size(118, 29);
            this.comboBoxTimeview.TabIndex = 76;
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSum.Location = new System.Drawing.Point(104, 279);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(0, 21);
            this.labelSum.TabIndex = 79;
            // 
            // labelItog
            // 
            this.labelItog.AutoSize = true;
            this.labelItog.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelItog.Location = new System.Drawing.Point(27, 279);
            this.labelItog.Name = "labelItog";
            this.labelItog.Size = new System.Drawing.Size(63, 21);
            this.labelItog.TabIndex = 78;
            this.labelItog.Text = "Итого:";
            // 
            // clientTableAdapter1
            // 
            this.clientTableAdapter1.ClearBeforeFill = true;
            // 
            // FormBuyingTicketsIceSkate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.labelItog);
            this.Controls.Add(this.labelViewtime);
            this.Controls.Add(this.comboBoxTimeview);
            this.Controls.Add(this.buttonViewTicket);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelBuyFilm);
            this.Controls.Add(this.numericUpDownRad);
            this.Controls.Add(this.labelRad);
            this.Controls.Add(this.numericUpDownPlace);
            this.Controls.Add(this.labelMesto);
            this.Controls.Add(this.numericUpDownZal);
            this.Controls.Add(this.labelZal);
            this.Controls.Add(this.labelEventname);
            this.Controls.Add(this.comboBoxIcebuy);
            this.Controls.Add(this.buttonBuyTicket);
            this.Name = "FormBuyingTicketsIceSkate";
            this.Text = "FormBuyingTicketsIceSkate";
            this.Load += new System.EventHandler(this.FormBuyingTicketsIceSkate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonViewTicket;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelBuyFilm;
        private System.Windows.Forms.NumericUpDown numericUpDownRad;
        private System.Windows.Forms.Label labelRad;
        private System.Windows.Forms.NumericUpDown numericUpDownPlace;
        private System.Windows.Forms.Label labelMesto;
        private System.Windows.Forms.NumericUpDown numericUpDownZal;
        private System.Windows.Forms.Label labelZal;
        private System.Windows.Forms.Label labelEventname;
        private System.Windows.Forms.ComboBox comboBoxIcebuy;
        private System.Windows.Forms.Button buttonBuyTicket;
        private DBTicketDataSetTableAdapters.TicketClientTableAdapter ticketClientTableAdapter1;
        private System.Windows.Forms.Label labelViewtime;
        private System.Windows.Forms.ComboBox comboBoxTimeview;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Label labelItog;
        private DBTicketDataSetTableAdapters.ClientTableAdapter clientTableAdapter1;
    }
}