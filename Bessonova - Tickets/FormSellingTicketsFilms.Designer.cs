
namespace Bessonova___Tickets
{
    partial class FormSellingTicketsFilms
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
            this.buttonSellTicket = new System.Windows.Forms.Button();
            this.comboBoxFilm = new System.Windows.Forms.ComboBox();
            this.labelEventname = new System.Windows.Forms.Label();
            this.labelZal = new System.Windows.Forms.Label();
            this.numericUpDownZal = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPlace = new System.Windows.Forms.NumericUpDown();
            this.labelMesto = new System.Windows.Forms.Label();
            this.numericUpDownRad = new System.Windows.Forms.NumericUpDown();
            this.labelRad = new System.Windows.Forms.Label();
            this.labelSelFilm = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonViewTicket = new System.Windows.Forms.Button();
            this.labelItog = new System.Windows.Forms.Label();
            this.labelSum = new System.Windows.Forms.Label();
            this.labelIDTicket = new System.Windows.Forms.Label();
            this.textBoxIDTicket = new System.Windows.Forms.TextBox();
            this.labelViewtime = new System.Windows.Forms.Label();
            this.comboBoxTimeview = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRad)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSellTicket
            // 
            this.buttonSellTicket.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSellTicket.Location = new System.Drawing.Point(595, 407);
            this.buttonSellTicket.Name = "buttonSellTicket";
            this.buttonSellTicket.Size = new System.Drawing.Size(193, 28);
            this.buttonSellTicket.TabIndex = 0;
            this.buttonSellTicket.Text = "Продать билет";
            this.buttonSellTicket.UseVisualStyleBackColor = true;
            this.buttonSellTicket.Click += new System.EventHandler(this.buttonSellTicket_Click);
            // 
            // comboBoxFilm
            // 
            this.comboBoxFilm.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxFilm.FormattingEnabled = true;
            this.comboBoxFilm.Location = new System.Drawing.Point(125, 144);
            this.comboBoxFilm.Name = "comboBoxFilm";
            this.comboBoxFilm.Size = new System.Drawing.Size(201, 29);
            this.comboBoxFilm.TabIndex = 1;
            this.comboBoxFilm.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilm_SelectedIndexChanged);
            // 
            // labelEventname
            // 
            this.labelEventname.AutoSize = true;
            this.labelEventname.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEventname.Location = new System.Drawing.Point(24, 145);
            this.labelEventname.Name = "labelEventname";
            this.labelEventname.Size = new System.Drawing.Size(84, 21);
            this.labelEventname.TabIndex = 2;
            this.labelEventname.Text = "Название";
            // 
            // labelZal
            // 
            this.labelZal.AutoSize = true;
            this.labelZal.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelZal.Location = new System.Drawing.Point(35, 210);
            this.labelZal.Name = "labelZal";
            this.labelZal.Size = new System.Drawing.Size(37, 21);
            this.labelZal.TabIndex = 3;
            this.labelZal.Text = "Зал";
            // 
            // numericUpDownZal
            // 
            this.numericUpDownZal.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownZal.Location = new System.Drawing.Point(105, 202);
            this.numericUpDownZal.Name = "numericUpDownZal";
            this.numericUpDownZal.Size = new System.Drawing.Size(120, 29);
            this.numericUpDownZal.TabIndex = 4;
            this.numericUpDownZal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownPlace
            // 
            this.numericUpDownPlace.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownPlace.Location = new System.Drawing.Point(595, 151);
            this.numericUpDownPlace.Name = "numericUpDownPlace";
            this.numericUpDownPlace.Size = new System.Drawing.Size(120, 29);
            this.numericUpDownPlace.TabIndex = 6;
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
            this.labelMesto.Location = new System.Drawing.Point(525, 159);
            this.labelMesto.Name = "labelMesto";
            this.labelMesto.Size = new System.Drawing.Size(61, 21);
            this.labelMesto.TabIndex = 5;
            this.labelMesto.Text = "Место";
            // 
            // numericUpDownRad
            // 
            this.numericUpDownRad.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownRad.Location = new System.Drawing.Point(595, 93);
            this.numericUpDownRad.Name = "numericUpDownRad";
            this.numericUpDownRad.Size = new System.Drawing.Size(120, 29);
            this.numericUpDownRad.TabIndex = 8;
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
            this.labelRad.Location = new System.Drawing.Point(525, 101);
            this.labelRad.Name = "labelRad";
            this.labelRad.Size = new System.Drawing.Size(39, 21);
            this.labelRad.TabIndex = 7;
            this.labelRad.Text = "Ряд";
            // 
            // labelSelFilm
            // 
            this.labelSelFilm.AutoSize = true;
            this.labelSelFilm.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSelFilm.Location = new System.Drawing.Point(303, 19);
            this.labelSelFilm.Name = "labelSelFilm";
            this.labelSelFilm.Size = new System.Drawing.Size(156, 22);
            this.labelSelFilm.TabIndex = 9;
            this.labelSelFilm.Text = "Продажа билета ";
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(595, 15);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(193, 30);
            this.buttonBack.TabIndex = 32;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonViewTicket
            // 
            this.buttonViewTicket.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonViewTicket.Location = new System.Drawing.Point(12, 410);
            this.buttonViewTicket.Name = "buttonViewTicket";
            this.buttonViewTicket.Size = new System.Drawing.Size(193, 28);
            this.buttonViewTicket.TabIndex = 35;
            this.buttonViewTicket.Text = "Просмотреть билет";
            this.buttonViewTicket.UseVisualStyleBackColor = true;
            this.buttonViewTicket.Click += new System.EventHandler(this.buttonViewTicket_Click);
            // 
            // labelItog
            // 
            this.labelItog.AutoSize = true;
            this.labelItog.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelItog.Location = new System.Drawing.Point(24, 307);
            this.labelItog.Name = "labelItog";
            this.labelItog.Size = new System.Drawing.Size(63, 21);
            this.labelItog.TabIndex = 36;
            this.labelItog.Text = "Итого:";
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSum.Location = new System.Drawing.Point(101, 307);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(0, 21);
            this.labelSum.TabIndex = 37;
            // 
            // labelIDTicket
            // 
            this.labelIDTicket.AutoSize = true;
            this.labelIDTicket.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIDTicket.Location = new System.Drawing.Point(24, 96);
            this.labelIDTicket.Name = "labelIDTicket";
            this.labelIDTicket.Size = new System.Drawing.Size(87, 21);
            this.labelIDTicket.TabIndex = 39;
            this.labelIDTicket.Text = "ID билета";
            // 
            // textBoxIDTicket
            // 
            this.textBoxIDTicket.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxIDTicket.Location = new System.Drawing.Point(135, 96);
            this.textBoxIDTicket.Name = "textBoxIDTicket";
            this.textBoxIDTicket.Size = new System.Drawing.Size(100, 29);
            this.textBoxIDTicket.TabIndex = 40;
            // 
            // labelViewtime
            // 
            this.labelViewtime.AutoSize = true;
            this.labelViewtime.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelViewtime.Location = new System.Drawing.Point(433, 210);
            this.labelViewtime.Name = "labelViewtime";
            this.labelViewtime.Size = new System.Drawing.Size(153, 21);
            this.labelViewtime.TabIndex = 67;
            this.labelViewtime.Text = "Время просмотра";
            // 
            // comboBoxTimeview
            // 
            this.comboBoxTimeview.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxTimeview.FormattingEnabled = true;
            this.comboBoxTimeview.Location = new System.Drawing.Point(592, 207);
            this.comboBoxTimeview.Name = "comboBoxTimeview";
            this.comboBoxTimeview.Size = new System.Drawing.Size(118, 29);
            this.comboBoxTimeview.TabIndex = 66;
            // 
            // FormSellingTicketsFilms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelViewtime);
            this.Controls.Add(this.comboBoxTimeview);
            this.Controls.Add(this.textBoxIDTicket);
            this.Controls.Add(this.labelIDTicket);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.labelItog);
            this.Controls.Add(this.buttonViewTicket);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelSelFilm);
            this.Controls.Add(this.numericUpDownRad);
            this.Controls.Add(this.labelRad);
            this.Controls.Add(this.numericUpDownPlace);
            this.Controls.Add(this.labelMesto);
            this.Controls.Add(this.numericUpDownZal);
            this.Controls.Add(this.labelZal);
            this.Controls.Add(this.labelEventname);
            this.Controls.Add(this.comboBoxFilm);
            this.Controls.Add(this.buttonSellTicket);
            this.Name = "FormSellingTicketsFilms";
            this.Text = "Билетная система";
            this.Load += new System.EventHandler(this.FormSellingTicketsFilms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSellTicket;
        private System.Windows.Forms.ComboBox comboBoxFilm;
        private System.Windows.Forms.Label labelEventname;
        private System.Windows.Forms.Label labelZal;
        private System.Windows.Forms.NumericUpDown numericUpDownZal;
        private System.Windows.Forms.NumericUpDown numericUpDownPlace;
        private System.Windows.Forms.Label labelMesto;
        private System.Windows.Forms.NumericUpDown numericUpDownRad;
        private System.Windows.Forms.Label labelRad;
        private System.Windows.Forms.Label labelSelFilm;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonViewTicket;
        private System.Windows.Forms.Label labelItog;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Label labelIDTicket;
        private System.Windows.Forms.TextBox textBoxIDTicket;
        private System.Windows.Forms.Label labelViewtime;
        private System.Windows.Forms.ComboBox comboBoxTimeview;
    }
}