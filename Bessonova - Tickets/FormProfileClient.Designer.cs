
namespace Bessonova___Tickets
{
    partial class FormProfileClient
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
            this.labelProfile = new System.Windows.Forms.Label();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.buttonBacktoMenu = new System.Windows.Forms.Button();
            this.buttonUpdateprofile = new System.Windows.Forms.Button();
            this.buttonPhotopick = new System.Windows.Forms.Button();
            this.textBoxWallet = new System.Windows.Forms.TextBox();
            this.labelRub = new System.Windows.Forms.Label();
            this.labelWallet = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.labelBirth = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.maskedTextBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.labelLastname = new System.Windows.Forms.Label();
            this.labelFirstname = new System.Windows.Forms.Label();
            this.dateTimePickerBirth = new System.Windows.Forms.DateTimePicker();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.buttonAddprofile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxinfo = new System.Windows.Forms.GroupBox();
            this.labelIDNum = new System.Windows.Forms.Label();
            this.labelPas = new System.Windows.Forms.Label();
            this.labelLogEmail = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.genderTableAdapter1 = new Bessonova___Tickets.DBTicketDataSetTableAdapters.GenderTableAdapter();
            this.usersTableAdapter1 = new Bessonova___Tickets.DBTicketDataSetTableAdapters.UsersTableAdapter();
            this.clientProfTableAdapter1 = new Bessonova___Tickets.DBTicketDataSetTableAdapters.ClientProfTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.groupBoxinfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelProfile
            // 
            this.labelProfile.AutoSize = true;
            this.labelProfile.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProfile.Location = new System.Drawing.Point(322, 9);
            this.labelProfile.Name = "labelProfile";
            this.labelProfile.Size = new System.Drawing.Size(129, 22);
            this.labelProfile.TabIndex = 29;
            this.labelProfile.Text = "Ваш профиль";
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(798, 73);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(121, 119);
            this.pictureBoxProfile.TabIndex = 30;
            this.pictureBoxProfile.TabStop = false;
            // 
            // buttonBacktoMenu
            // 
            this.buttonBacktoMenu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBacktoMenu.Location = new System.Drawing.Point(785, 9);
            this.buttonBacktoMenu.Name = "buttonBacktoMenu";
            this.buttonBacktoMenu.Size = new System.Drawing.Size(151, 33);
            this.buttonBacktoMenu.TabIndex = 38;
            this.buttonBacktoMenu.Text = "Назад";
            this.buttonBacktoMenu.UseVisualStyleBackColor = true;
            this.buttonBacktoMenu.Click += new System.EventHandler(this.buttonBacktoMenu_Click);
            // 
            // buttonUpdateprofile
            // 
            this.buttonUpdateprofile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdateprofile.Location = new System.Drawing.Point(24, 378);
            this.buttonUpdateprofile.Name = "buttonUpdateprofile";
            this.buttonUpdateprofile.Size = new System.Drawing.Size(198, 33);
            this.buttonUpdateprofile.TabIndex = 70;
            this.buttonUpdateprofile.Text = "Редактировать профиль";
            this.buttonUpdateprofile.UseVisualStyleBackColor = true;
            this.buttonUpdateprofile.Click += new System.EventHandler(this.buttonUpdateprofile_Click);
            // 
            // buttonPhotopick
            // 
            this.buttonPhotopick.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPhotopick.Location = new System.Drawing.Point(785, 211);
            this.buttonPhotopick.Name = "buttonPhotopick";
            this.buttonPhotopick.Size = new System.Drawing.Size(151, 33);
            this.buttonPhotopick.TabIndex = 69;
            this.buttonPhotopick.Text = "Выбрать фото";
            this.buttonPhotopick.UseVisualStyleBackColor = true;
            this.buttonPhotopick.Click += new System.EventHandler(this.buttonPhotopick_Click);
            // 
            // textBoxWallet
            // 
            this.textBoxWallet.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxWallet.Location = new System.Drawing.Point(480, 163);
            this.textBoxWallet.Name = "textBoxWallet";
            this.textBoxWallet.Size = new System.Drawing.Size(178, 29);
            this.textBoxWallet.TabIndex = 71;
            // 
            // labelRub
            // 
            this.labelRub.AutoSize = true;
            this.labelRub.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRub.Location = new System.Drawing.Point(664, 163);
            this.labelRub.Name = "labelRub";
            this.labelRub.Size = new System.Drawing.Size(45, 21);
            this.labelRub.TabIndex = 73;
            this.labelRub.Text = "Руб.";
            // 
            // labelWallet
            // 
            this.labelWallet.AutoSize = true;
            this.labelWallet.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWallet.Location = new System.Drawing.Point(396, 166);
            this.labelWallet.Name = "labelWallet";
            this.labelWallet.Size = new System.Drawing.Size(80, 21);
            this.labelWallet.TabIndex = 72;
            this.labelWallet.Text = "Кошелек";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGender.Location = new System.Drawing.Point(396, 99);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(42, 21);
            this.labelGender.TabIndex = 84;
            this.labelGender.Text = "Пол";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Location = new System.Drawing.Point(465, 96);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(222, 29);
            this.comboBoxGender.TabIndex = 83;
            // 
            // labelBirth
            // 
            this.labelBirth.AutoSize = true;
            this.labelBirth.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBirth.Location = new System.Drawing.Point(21, 255);
            this.labelBirth.Name = "labelBirth";
            this.labelBirth.Size = new System.Drawing.Size(132, 21);
            this.labelBirth.TabIndex = 82;
            this.labelBirth.Text = "Дата рождения";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhone.Location = new System.Drawing.Point(33, 209);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(78, 21);
            this.labelPhone.TabIndex = 81;
            this.labelPhone.Text = "Телефон";
            // 
            // maskedTextBoxPhone
            // 
            this.maskedTextBoxPhone.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBoxPhone.Location = new System.Drawing.Point(117, 201);
            this.maskedTextBoxPhone.Mask = "+7(999)999-99-99";
            this.maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            this.maskedTextBoxPhone.Size = new System.Drawing.Size(234, 29);
            this.maskedTextBoxPhone.TabIndex = 80;
            // 
            // labelLastname
            // 
            this.labelLastname.AutoSize = true;
            this.labelLastname.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLastname.Location = new System.Drawing.Point(29, 153);
            this.labelLastname.Name = "labelLastname";
            this.labelLastname.Size = new System.Drawing.Size(82, 21);
            this.labelLastname.TabIndex = 79;
            this.labelLastname.Text = "Фамилия";
            // 
            // labelFirstname
            // 
            this.labelFirstname.AutoSize = true;
            this.labelFirstname.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirstname.Location = new System.Drawing.Point(36, 103);
            this.labelFirstname.Name = "labelFirstname";
            this.labelFirstname.Size = new System.Drawing.Size(44, 21);
            this.labelFirstname.TabIndex = 78;
            this.labelFirstname.Text = "Имя";
            // 
            // dateTimePickerBirth
            // 
            this.dateTimePickerBirth.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerBirth.Location = new System.Drawing.Point(170, 249);
            this.dateTimePickerBirth.Name = "dateTimePickerBirth";
            this.dateTimePickerBirth.Size = new System.Drawing.Size(218, 29);
            this.dateTimePickerBirth.TabIndex = 77;
            this.dateTimePickerBirth.ValueChanged += new System.EventHandler(this.dateTimePickerBirth_ValueChanged);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLastName.Location = new System.Drawing.Point(117, 150);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(234, 29);
            this.textBoxLastName.TabIndex = 75;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFirstName.Location = new System.Drawing.Point(117, 103);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(234, 29);
            this.textBoxFirstName.TabIndex = 74;
            // 
            // buttonAddprofile
            // 
            this.buttonAddprofile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddprofile.Location = new System.Drawing.Point(25, 339);
            this.buttonAddprofile.Name = "buttonAddprofile";
            this.buttonAddprofile.Size = new System.Drawing.Size(198, 33);
            this.buttonAddprofile.TabIndex = 85;
            this.buttonAddprofile.Text = "Добавить профиль";
            this.buttonAddprofile.UseVisualStyleBackColor = true;
            this.buttonAddprofile.Click += new System.EventHandler(this.buttonAddprofile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBoxinfo
            // 
            this.groupBoxinfo.Controls.Add(this.labelIDNum);
            this.groupBoxinfo.Controls.Add(this.labelPas);
            this.groupBoxinfo.Controls.Add(this.labelLogEmail);
            this.groupBoxinfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxinfo.Location = new System.Drawing.Point(449, 272);
            this.groupBoxinfo.Name = "groupBoxinfo";
            this.groupBoxinfo.Size = new System.Drawing.Size(338, 166);
            this.groupBoxinfo.TabIndex = 86;
            this.groupBoxinfo.TabStop = false;
            this.groupBoxinfo.Text = "Логин и пароль";
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
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAge.Location = new System.Drawing.Point(400, 230);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(53, 21);
            this.labelAge.TabIndex = 87;
            this.labelAge.Text = "label1";
            // 
            // genderTableAdapter1
            // 
            this.genderTableAdapter1.ClearBeforeFill = true;
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // clientProfTableAdapter1
            // 
            this.clientProfTableAdapter1.ClearBeforeFill = true;
            // 
            // FormProfileClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 450);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.groupBoxinfo);
            this.Controls.Add(this.buttonAddprofile);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.labelBirth);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.maskedTextBoxPhone);
            this.Controls.Add(this.labelLastname);
            this.Controls.Add(this.labelFirstname);
            this.Controls.Add(this.dateTimePickerBirth);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelRub);
            this.Controls.Add(this.labelWallet);
            this.Controls.Add(this.textBoxWallet);
            this.Controls.Add(this.buttonUpdateprofile);
            this.Controls.Add(this.buttonPhotopick);
            this.Controls.Add(this.buttonBacktoMenu);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.labelProfile);
            this.Name = "FormProfileClient";
            this.Text = "Билетная система";
            this.Load += new System.EventHandler(this.FormProfileClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.groupBoxinfo.ResumeLayout(false);
            this.groupBoxinfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProfile;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Button buttonBacktoMenu;
        private System.Windows.Forms.Button buttonUpdateprofile;
        private System.Windows.Forms.Button buttonPhotopick;
        private System.Windows.Forms.TextBox textBoxWallet;
        private System.Windows.Forms.Label labelRub;
        private System.Windows.Forms.Label labelWallet;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label labelBirth;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhone;
        private System.Windows.Forms.Label labelLastname;
        private System.Windows.Forms.Label labelFirstname;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirth;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Button buttonAddprofile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBoxinfo;
        private System.Windows.Forms.Label labelLogEmail;
        private System.Windows.Forms.Label labelPas;
        private DBTicketDataSetTableAdapters.GenderTableAdapter genderTableAdapter1;
        private DBTicketDataSetTableAdapters.UsersTableAdapter usersTableAdapter1;
        private System.Windows.Forms.Label labelIDNum;
        private System.Windows.Forms.Label labelAge;
        private DBTicketDataSetTableAdapters.ClientProfTableAdapter clientProfTableAdapter1;
    }
}