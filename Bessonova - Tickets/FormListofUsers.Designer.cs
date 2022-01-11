
namespace Bessonova___Tickets
{
    partial class FormListofUsers
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
            this.dataGridViewlist = new System.Windows.Forms.DataGridView();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonMore = new System.Windows.Forms.Button();
            this.labelListofusers = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewlist)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewlist
            // 
            this.dataGridViewlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewlist.Location = new System.Drawing.Point(12, 116);
            this.dataGridViewlist.Name = "dataGridViewlist";
            this.dataGridViewlist.Size = new System.Drawing.Size(776, 322);
            this.dataGridViewlist.TabIndex = 0;
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(595, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(193, 30);
            this.buttonBack.TabIndex = 30;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonMore
            // 
            this.buttonMore.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMore.Location = new System.Drawing.Point(12, 80);
            this.buttonMore.Name = "buttonMore";
            this.buttonMore.Size = new System.Drawing.Size(193, 30);
            this.buttonMore.TabIndex = 31;
            this.buttonMore.Text = "Подробно";
            this.buttonMore.UseVisualStyleBackColor = true;
            this.buttonMore.Click += new System.EventHandler(this.buttonMore_Click);
            // 
            // labelListofusers
            // 
            this.labelListofusers.AutoSize = true;
            this.labelListofusers.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelListofusers.Location = new System.Drawing.Point(273, 12);
            this.labelListofusers.Name = "labelListofusers";
            this.labelListofusers.Size = new System.Drawing.Size(210, 22);
            this.labelListofusers.TabIndex = 32;
            this.labelListofusers.Text = "Список пользователей";
            // 
            // FormListofUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelListofusers);
            this.Controls.Add(this.buttonMore);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.dataGridViewlist);
            this.Name = "FormListofUsers";
            this.Text = "Билетная система";
            this.Load += new System.EventHandler(this.FormListofUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewlist;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonMore;
        private System.Windows.Forms.Label labelListofusers;
    }
}