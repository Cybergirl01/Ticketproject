
namespace Bessonova___Tickets
{
    partial class FormListofEvents
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
            this.dataGridViewEvents = new System.Windows.Forms.DataGridView();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelHis = new System.Windows.Forms.Label();
            this.buttonAddevent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEvents
            // 
            this.dataGridViewEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEvents.Location = new System.Drawing.Point(12, 89);
            this.dataGridViewEvents.Name = "dataGridViewEvents";
            this.dataGridViewEvents.Size = new System.Drawing.Size(776, 349);
            this.dataGridViewEvents.TabIndex = 0;
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(595, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(193, 30);
            this.buttonBack.TabIndex = 31;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelHis
            // 
            this.labelHis.AutoSize = true;
            this.labelHis.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHis.Location = new System.Drawing.Point(292, 17);
            this.labelHis.Name = "labelHis";
            this.labelHis.Size = new System.Drawing.Size(183, 21);
            this.labelHis.TabIndex = 32;
            this.labelHis.Text = "Список мероприятий";
            // 
            // buttonAddevent
            // 
            this.buttonAddevent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddevent.Location = new System.Drawing.Point(12, 53);
            this.buttonAddevent.Name = "buttonAddevent";
            this.buttonAddevent.Size = new System.Drawing.Size(193, 30);
            this.buttonAddevent.TabIndex = 33;
            this.buttonAddevent.Text = "Добавить";
            this.buttonAddevent.UseVisualStyleBackColor = true;
            this.buttonAddevent.Click += new System.EventHandler(this.buttonAddevent_Click);
            // 
            // FormListofEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAddevent);
            this.Controls.Add(this.labelHis);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.dataGridViewEvents);
            this.Name = "FormListofEvents";
            this.Text = "Билетная система";
            this.Load += new System.EventHandler(this.FormListofEvents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEvents;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelHis;
        private System.Windows.Forms.Button buttonAddevent;
    }
}