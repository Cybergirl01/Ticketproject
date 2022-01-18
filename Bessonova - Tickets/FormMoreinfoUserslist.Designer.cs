
namespace Bessonova___Tickets
{
    partial class FormMoreinfoUserslist
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
            this.flowLayoutPanelInfousers = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelClient = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelSeller = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelOrganaisers = new System.Windows.Forms.FlowLayoutPanel();
            this.labelListofusers = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanelInfousers
            // 
            this.flowLayoutPanelInfousers.Location = new System.Drawing.Point(13, 127);
            this.flowLayoutPanelInfousers.Name = "flowLayoutPanelInfousers";
            this.flowLayoutPanelInfousers.Size = new System.Drawing.Size(335, 311);
            this.flowLayoutPanelInfousers.TabIndex = 0;
            // 
            // flowLayoutPanelClient
            // 
            this.flowLayoutPanelClient.Location = new System.Drawing.Point(373, 129);
            this.flowLayoutPanelClient.Name = "flowLayoutPanelClient";
            this.flowLayoutPanelClient.Size = new System.Drawing.Size(325, 311);
            this.flowLayoutPanelClient.TabIndex = 1;
            // 
            // flowLayoutPanelSeller
            // 
            this.flowLayoutPanelSeller.Location = new System.Drawing.Point(719, 127);
            this.flowLayoutPanelSeller.Name = "flowLayoutPanelSeller";
            this.flowLayoutPanelSeller.Size = new System.Drawing.Size(317, 311);
            this.flowLayoutPanelSeller.TabIndex = 1;
            // 
            // flowLayoutPanelOrganaisers
            // 
            this.flowLayoutPanelOrganaisers.Location = new System.Drawing.Point(1055, 127);
            this.flowLayoutPanelOrganaisers.Name = "flowLayoutPanelOrganaisers";
            this.flowLayoutPanelOrganaisers.Size = new System.Drawing.Size(317, 311);
            this.flowLayoutPanelOrganaisers.TabIndex = 2;
            // 
            // labelListofusers
            // 
            this.labelListofusers.AutoSize = true;
            this.labelListofusers.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelListofusers.Location = new System.Drawing.Point(589, 9);
            this.labelListofusers.Name = "labelListofusers";
            this.labelListofusers.Size = new System.Drawing.Size(310, 22);
            this.labelListofusers.TabIndex = 33;
            this.labelListofusers.Text = "Подробный список пользователей";
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(1221, 5);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(193, 30);
            this.buttonBack.TabIndex = 34;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // FormMoreinfoUserslist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 452);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelListofusers);
            this.Controls.Add(this.flowLayoutPanelOrganaisers);
            this.Controls.Add(this.flowLayoutPanelSeller);
            this.Controls.Add(this.flowLayoutPanelClient);
            this.Controls.Add(this.flowLayoutPanelInfousers);
            this.Name = "FormMoreinfoUserslist";
            this.Text = "Билетная система";
            this.Load += new System.EventHandler(this.FormMoreinfoUserslist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelInfousers;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelClient;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSeller;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelOrganaisers;
        private System.Windows.Forms.Label labelListofusers;
        private System.Windows.Forms.Button buttonBack;
    }
}