
namespace Bessonova___Tickets
{
    partial class FormProfileSeller
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
            this.buttonBacktoMenu = new System.Windows.Forms.Button();
            this.labelProfile = new System.Windows.Forms.Label();
            this.buttonUpdateprofile = new System.Windows.Forms.Button();
            this.buttonPhotopick = new System.Windows.Forms.Button();
            this.labelWorkplace = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.labelBirth = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.maskedTextBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelFirstname = new System.Windows.Forms.Label();
            this.dateTimePickerBirth = new System.Windows.Forms.DateTimePicker();
            this.textBoxWorkplace = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonAddprofile = new System.Windows.Forms.Button();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.labelIDNum = new System.Windows.Forms.Label();
            this.labelPas = new System.Windows.Forms.Label();
            this.labelLogEmail = new System.Windows.Forms.Label();
            this.genderTableAdapter1 = new Bessonova___Tickets.DBTicketDataSetTableAdapters.GenderTableAdapter();
            this.sellerTableAdapter1 = new Bessonova___Tickets.DBTicketDataSetTableAdapters.SellerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.groupBoxInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBacktoMenu
            // 
            this.buttonBacktoMenu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBacktoMenu.Location = new System.Drawing.Point(765, 12);
            this.buttonBacktoMenu.Name = "buttonBacktoMenu";
            this.buttonBacktoMenu.Size = new System.Drawing.Size(151, 33);
            this.buttonBacktoMenu.TabIndex = 48;
            this.buttonBacktoMenu.Text = "Назад";
            this.buttonBacktoMenu.UseVisualStyleBackColor = true;
            this.buttonBacktoMenu.Click += new System.EventHandler(this.buttonBacktoMenu_Click);
            // 
            // labelProfile
            // 
            this.labelProfile.AutoSize = true;
            this.labelProfile.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProfile.Location = new System.Drawing.Point(332, 12);
            this.labelProfile.Name = "labelProfile";
            this.labelProfile.Size = new System.Drawing.Size(129, 22);
            this.labelProfile.TabIndex = 39;
            this.labelProfile.Text = "Ваш профиль";
            // 
            // buttonUpdateprofile
            // 
            this.buttonUpdateprofile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdateprofile.Location = new System.Drawing.Point(57, 360);
            this.buttonUpdateprofile.Name = "buttonUpdateprofile";
            this.buttonUpdateprofile.Size = new System.Drawing.Size(198, 33);
            this.buttonUpdateprofile.TabIndex = 74;
            this.buttonUpdateprofile.Text = "Редактировать профиль";
            this.buttonUpdateprofile.UseVisualStyleBackColor = true;
            this.buttonUpdateprofile.Click += new System.EventHandler(this.buttonUpdateprofile_Click);
            // 
            // buttonPhotopick
            // 
            this.buttonPhotopick.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPhotopick.Location = new System.Drawing.Point(760, 220);
            this.buttonPhotopick.Name = "buttonPhotopick";
            this.buttonPhotopick.Size = new System.Drawing.Size(151, 33);
            this.buttonPhotopick.TabIndex = 73;
            this.buttonPhotopick.Text = "Выбрать фото";
            this.buttonPhotopick.UseVisualStyleBackColor = true;
            this.buttonPhotopick.Click += new System.EventHandler(this.buttonPhotopick_Click);
            // 
            // labelWorkplace
            // 
            this.labelWorkplace.AutoSize = true;
            this.labelWorkplace.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWorkplace.Location = new System.Drawing.Point(393, 187);
            this.labelWorkplace.Name = "labelWorkplace";
            this.labelWorkplace.Size = new System.Drawing.Size(125, 21);
            this.labelWorkplace.TabIndex = 72;
            this.labelWorkplace.Text = "Место работы";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGender.Location = new System.Drawing.Point(393, 118);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(42, 21);
            this.labelGender.TabIndex = 71;
            this.labelGender.Text = "Пол";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Location = new System.Drawing.Point(441, 115);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(222, 29);
            this.comboBoxGender.TabIndex = 70;
            // 
            // labelBirth
            // 
            this.labelBirth.AutoSize = true;
            this.labelBirth.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBirth.Location = new System.Drawing.Point(41, 272);
            this.labelBirth.Name = "labelBirth";
            this.labelBirth.Size = new System.Drawing.Size(132, 21);
            this.labelBirth.TabIndex = 69;
            this.labelBirth.Text = "Дата рождения";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhone.Location = new System.Drawing.Point(38, 226);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(78, 21);
            this.labelPhone.TabIndex = 68;
            this.labelPhone.Text = "Телефон";
            // 
            // maskedTextBoxPhone
            // 
            this.maskedTextBoxPhone.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBoxPhone.Location = new System.Drawing.Point(122, 218);
            this.maskedTextBoxPhone.Mask = "+7(999)999-99-99";
            this.maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            this.maskedTextBoxPhone.Size = new System.Drawing.Size(234, 29);
            this.maskedTextBoxPhone.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(34, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 66;
            this.label1.Text = "Фамилия";
            // 
            // labelFirstname
            // 
            this.labelFirstname.AutoSize = true;
            this.labelFirstname.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirstname.Location = new System.Drawing.Point(34, 123);
            this.labelFirstname.Name = "labelFirstname";
            this.labelFirstname.Size = new System.Drawing.Size(44, 21);
            this.labelFirstname.TabIndex = 65;
            this.labelFirstname.Text = "Имя";
            // 
            // dateTimePickerBirth
            // 
            this.dateTimePickerBirth.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerBirth.Location = new System.Drawing.Point(190, 266);
            this.dateTimePickerBirth.Name = "dateTimePickerBirth";
            this.dateTimePickerBirth.Size = new System.Drawing.Size(218, 29);
            this.dateTimePickerBirth.TabIndex = 64;
            // 
            // textBoxWorkplace
            // 
            this.textBoxWorkplace.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxWorkplace.Location = new System.Drawing.Point(524, 184);
            this.textBoxWorkplace.Name = "textBoxWorkplace";
            this.textBoxWorkplace.Size = new System.Drawing.Size(211, 29);
            this.textBoxWorkplace.TabIndex = 63;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLastName.Location = new System.Drawing.Point(122, 167);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(234, 29);
            this.textBoxLastName.TabIndex = 62;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFirstName.Location = new System.Drawing.Point(122, 120);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(234, 29);
            this.textBoxFirstName.TabIndex = 61;
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.Location = new System.Drawing.Point(770, 86);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(121, 119);
            this.pictureBoxPhoto.TabIndex = 60;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonAddprofile
            // 
            this.buttonAddprofile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddprofile.Location = new System.Drawing.Point(57, 321);
            this.buttonAddprofile.Name = "buttonAddprofile";
            this.buttonAddprofile.Size = new System.Drawing.Size(198, 33);
            this.buttonAddprofile.TabIndex = 86;
            this.buttonAddprofile.Text = "Добавить профиль";
            this.buttonAddprofile.UseVisualStyleBackColor = true;
            this.buttonAddprofile.Click += new System.EventHandler(this.buttonAddprofile_Click);
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.labelIDNum);
            this.groupBoxInfo.Controls.Add(this.labelPas);
            this.groupBoxInfo.Controls.Add(this.labelLogEmail);
            this.groupBoxInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInfo.Location = new System.Drawing.Point(416, 242);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(338, 166);
            this.groupBoxInfo.TabIndex = 87;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Логин и пароль";
            // 
            // labelIDNum
            // 
            this.labelIDNum.AutoSize = true;
            this.labelIDNum.Location = new System.Drawing.Point(12, 34);
            this.labelIDNum.Name = "labelIDNum";
            this.labelIDNum.Size = new System.Drawing.Size(45, 19);
            this.labelIDNum.TabIndex = 2;
            this.labelIDNum.Text = "label2";
            // 
            // labelPas
            // 
            this.labelPas.AutoSize = true;
            this.labelPas.Location = new System.Drawing.Point(12, 120);
            this.labelPas.Name = "labelPas";
            this.labelPas.Size = new System.Drawing.Size(45, 19);
            this.labelPas.TabIndex = 1;
            this.labelPas.Text = "label2";
            // 
            // labelLogEmail
            // 
            this.labelLogEmail.AutoSize = true;
            this.labelLogEmail.Location = new System.Drawing.Point(12, 79);
            this.labelLogEmail.Name = "labelLogEmail";
            this.labelLogEmail.Size = new System.Drawing.Size(45, 19);
            this.labelLogEmail.TabIndex = 0;
            this.labelLogEmail.Text = "label2";
            // 
            // genderTableAdapter1
            // 
            this.genderTableAdapter1.ClearBeforeFill = true;
            // 
            // sellerTableAdapter1
            // 
            this.sellerTableAdapter1.ClearBeforeFill = true;
            // 
            // FormProfileSeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 420);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.buttonAddprofile);
            this.Controls.Add(this.buttonUpdateprofile);
            this.Controls.Add(this.buttonPhotopick);
            this.Controls.Add(this.labelWorkplace);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.labelBirth);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.maskedTextBoxPhone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelFirstname);
            this.Controls.Add(this.dateTimePickerBirth);
            this.Controls.Add(this.textBoxWorkplace);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.pictureBoxPhoto);
            this.Controls.Add(this.buttonBacktoMenu);
            this.Controls.Add(this.labelProfile);
            this.Name = "FormProfileSeller";
            this.Text = "Билетная система";
            this.Load += new System.EventHandler(this.FormProfileSeller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBacktoMenu;
        private System.Windows.Forms.Label labelProfile;
        private System.Windows.Forms.Button buttonUpdateprofile;
        private System.Windows.Forms.Button buttonPhotopick;
        private System.Windows.Forms.Label labelWorkplace;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label labelBirth;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFirstname;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirth;
        private System.Windows.Forms.TextBox textBoxWorkplace;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonAddprofile;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.Label labelIDNum;
        private System.Windows.Forms.Label labelPas;
        private System.Windows.Forms.Label labelLogEmail;
        private DBTicketDataSetTableAdapters.GenderTableAdapter genderTableAdapter1;
        private DBTicketDataSetTableAdapters.SellerTableAdapter sellerTableAdapter1;
    }
}