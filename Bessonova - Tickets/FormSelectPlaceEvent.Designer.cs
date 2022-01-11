
namespace Bessonova___Tickets
{
    partial class FormSelectPlaceEvent
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
            this.buttonIceSkate = new System.Windows.Forms.Button();
            this.buttonFilm = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelSelect = new System.Windows.Forms.Label();
            this.labelInstrSel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonIceSkate
            // 
            this.buttonIceSkate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonIceSkate.Location = new System.Drawing.Point(286, 144);
            this.buttonIceSkate.Name = "buttonIceSkate";
            this.buttonIceSkate.Size = new System.Drawing.Size(184, 31);
            this.buttonIceSkate.TabIndex = 0;
            this.buttonIceSkate.Text = "Ледовый каток";
            this.buttonIceSkate.UseVisualStyleBackColor = true;
            this.buttonIceSkate.Click += new System.EventHandler(this.buttonIceSkate_Click);
            // 
            // buttonFilm
            // 
            this.buttonFilm.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFilm.Location = new System.Drawing.Point(286, 207);
            this.buttonFilm.Name = "buttonFilm";
            this.buttonFilm.Size = new System.Drawing.Size(184, 31);
            this.buttonFilm.TabIndex = 1;
            this.buttonFilm.Text = "Кино";
            this.buttonFilm.UseVisualStyleBackColor = true;
            this.buttonFilm.Click += new System.EventHandler(this.buttonFilm_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Times New Roman", 12.25F);
            this.buttonBack.Location = new System.Drawing.Point(647, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(141, 36);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelSelect
            // 
            this.labelSelect.AutoSize = true;
            this.labelSelect.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSelect.Location = new System.Drawing.Point(250, 12);
            this.labelSelect.Name = "labelSelect";
            this.labelSelect.Size = new System.Drawing.Size(242, 22);
            this.labelSelect.TabIndex = 3;
            this.labelSelect.Text = "Выбор места мероприятия";
            // 
            // labelInstrSel
            // 
            this.labelInstrSel.AutoSize = true;
            this.labelInstrSel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInstrSel.Location = new System.Drawing.Point(162, 74);
            this.labelInstrSel.Name = "labelInstrSel";
            this.labelInstrSel.Size = new System.Drawing.Size(469, 19);
            this.labelInstrSel.TabIndex = 4;
            this.labelInstrSel.Text = "Выберите место мероприятия, в котором собираетесь купить билет.";
            // 
            // FormSelectPlaceEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 444);
            this.Controls.Add(this.labelInstrSel);
            this.Controls.Add(this.labelSelect);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonFilm);
            this.Controls.Add(this.buttonIceSkate);
            this.Name = "FormSelectPlaceEvent";
            this.Text = "FormSelectPlaceEvent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonIceSkate;
        private System.Windows.Forms.Button buttonFilm;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelSelect;
        private System.Windows.Forms.Label labelInstrSel;
    }
}