using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bessonova___Tickets
{
    public partial class FormProfileClient : Form
    {
        string command;						//С какой целью открывается форма
        public FormProfileClient(string command)
        {
            InitializeComponent();
            this.command = command;

        }
   
        //По таблице Users
        DBTicketDataSet.UsersDataTable dataUsers;	//все данные из таблицы Users
        DBTicketDataSet.UsersRow rowUser;			//Отдельная строка таблицы
        //Данные по таблице Runners для редактирования
        DBTicketDataSet.ClientDataTable dataClient;   //все данные из таблицы 
        DBTicketDataSet.ClientRow rowClient;	//Отдельная строка таблицы
       // ClientsBLL client = new ClientsBLL(); - unused code piece
        private void buttonPhotopick_Click(object sender, EventArgs e)
        {
            if (buttonPhotopick.Text == "Выбрать фото")
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                  
                    pictureBoxProfile.Load(openFileDialog1.FileName);
                    buttonPhotopick.Text = "Удалить фото";
                }
            }
            else
            {
                pictureBoxProfile.Image = null;
                buttonPhotopick.Text = "Выбрать фото";
            }
        }

        private void buttonBacktoMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonUpdateprofile_Click(object sender, EventArgs e)
        {
            //Заполнить строку-шаблон данными из элементов формы
            string FirstName = textBoxFirstName.Text;
            string Lastname = textBoxLastName.Text;
            DateTime birthday = dateTimePickerBirth.Value;


            if (FirstName == "" || Lastname == "")
            {
                MessageBox.Show("Не заполнили имя или фамилию");
                return;
            }


            rowClient.FirstName = FirstName;
            rowClient.LastName = Lastname;
            rowClient.IDGender = (int)comboBoxGender.SelectedValue;
            rowClient.Birthday = dateTimePickerBirth.Value;

            rowClient.PhoneNumber = maskedTextBoxPhone.Text;
            rowClient.Wallet = decimal.Parse(textBoxWallet.Text);
            //Подготовка к сохранению фото в БД
            if (pictureBoxProfile.Image != null)
            {
                MemoryStream stream = new System.IO.MemoryStream();	//Промежуточный поток
                pictureBoxProfile.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                rowClient.Photo = stream.ToArray();
            }
            else
            {
                rowClient.Photo = null;
            }
            try
            {
                //Перенести измененные данные в БД
                clientTableAdapter1.Update(rowClient);
                MessageBox.Show("Ваш профиль обновлен в системе");
                buttonPhotopick.Enabled = false;
                buttonBacktoMenu.Enabled = true;		//Открыт доступ к функционалу 
            }
            catch
            {
                MessageBox.Show("Ошибка при обновлении профиля");
            }
        }

        private void FormProfileClient_Load(object sender, EventArgs e)
        {
            //Начальные настройки интерфейса
            buttonAddprofile.Visible = false;
            buttonBacktoMenu.Enabled = true;
            textBoxWallet.Enabled = false;
           
            openFileDialog1.Filter = "jpg|*.jpg|png|*.png";
            //Данные из таблицы Users, которые нельзя менять
            dataUsers = this.usersTableAdapter1.GetData();
            rowUser = dataUsers.FindByID(ClassforIDUsers.idU);
            labelIDNum.Text = "Ваш номер: " + rowUser.ID.ToString();
            labelLogEmail.Text = "Ваш логин: " + rowUser.Email;
            labelPas.Text = "Ваш пароль: " + rowUser.Password;
            //Настройка списков
          
            comboBoxGender.DataSource = genderTableAdapter1.GetData();
            comboBoxGender.DisplayMember = "Title";
            comboBoxGender.ValueMember = "ID";


            switch (command)
            {
                case "Addition":
                    buttonAddprofile.Visible = true;
                    buttonBacktoMenu.Enabled = false;
                    buttonUpdateprofile.Visible = false;
                    textBoxWallet.Text = "0,00";
                   
                    break;

                case "ViewEdit":
                    buttonUpdateprofile.Visible = true;
                    dataClient = clientTableAdapter1.GetData(); 	//Все данные из таблицы
                    //Поиск среди них запись с нужным ID
                    rowClient = dataClient.FindByID(ClassforIDUsers.idU);
                    //Перенос данных из записи в элементы интерфейса
                    textBoxWallet.Text = rowClient.Wallet.ToString();
                    textBoxFirstName.Text = rowClient.FirstName;
                    textBoxLastName.Text = rowClient.LastName;
                    comboBoxGender.SelectedValue = rowClient.IDGender;
                    dateTimePickerBirth.Value = rowClient.Birthday;
                   
                    maskedTextBoxPhone.Text = rowClient.PhoneNumber;
                    
                    //Получить фото из БД и отобразить его в компоненте
                    if (rowClient.IsPhotoNull())		//проверка пустого значения в поле фото
                    {
                        pictureBoxProfile.Image = Properties.Resources.NotPicture;
                    }
                    else
                    {
                        byte[] photo = rowClient.Photo;
                        MemoryStream stream = new MemoryStream(photo);
                        Image bit = Image.FromStream(stream);
                        pictureBoxProfile.Image = bit;
                    }
                    break;
            }
        }

        private void buttonAddprofile_Click(object sender, EventArgs e)
        {
            byte[] photo = null;
            //Получить данные из элементов интерфейса
            string firstName = textBoxFirstName.Text;
            string Lastname = textBoxLastName.Text;
            if (firstName == "" || Lastname == "")
            {
                MessageBox.Show("Не заполнили имя или фамилию");
                return;
            }
            //Данные из списков ComboBox
            int idGender = (int)comboBoxGender.SelectedValue;
            DateTime birthday = dateTimePickerBirth.Value;


           
            string phone = maskedTextBoxPhone.Text;
            decimal wallet = decimal.Parse(textBoxWallet.Text);
            //Работа с фото
            if (pictureBoxProfile.Image != null)
            {
                photo = File.ReadAllBytes(openFileDialog1.FileName); //в массив
            }
            try
            {
                //Метод Insert адаптера 
                clientTableAdapter1.Insert(ClassforIDUsers.idU, firstName, Lastname, idGender, birthday, phone, wallet, photo);
                MessageBox.Show("Ваш профиль добавлен в систему");
                buttonAddprofile.Visible = false;
                buttonPhotopick.Enabled = false;
                buttonBacktoMenu.Enabled = true;		//доступ к функционалу 
            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении профиля");
            }
        }

        private void dateTimePickerBirth_ValueChanged(object sender, EventArgs e)
        {

            int Age = DateTime.Today.Year - dateTimePickerBirth.Value.Year; // CurrentYear - BirthDate
            if (Age < 10)
                MessageBox.Show(String.Format("Возраст: ", Age) + "Вы не можете быть моложе 10 лет.");

            labelAge.Text ="Возраст: " + Age.ToString();
        }
    }
}
