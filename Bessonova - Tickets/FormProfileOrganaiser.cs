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
    public partial class FormProfileOrganaiser : Form
    { public int idEventPlace;
        string command;
        DBTicketDataSet.OrganaisersDataTable org;
        OrganaiserBLL organaiser = new OrganaiserBLL();
        DBTicketDataSet.OrganaisersRow organaisersRow;
        //По таблице Users
        DBTicketDataSet.UsersDataTable dataUsers;	//все данные из таблицы Users
        DBTicketDataSet.UsersRow rowUser;
        public FormProfileOrganaiser(string command)
        {
            InitializeComponent();
            this.command = command;

        }
        
        private void buttonBacktoMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPhotopick_Click(object sender, EventArgs e)
        {

            if (buttonPhotopick.Text == "Выбрать фото")
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    pictureBoxPhoto.Load(openFileDialog1.FileName);
                    buttonPhotopick.Text = "Удалить фото";
                }
            }
            else
            {
                pictureBoxPhoto.Image = null;
                buttonPhotopick.Text = "Выбрать фото";
            }
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


            organaisersRow.FirstName = FirstName;
            organaisersRow.LastName = Lastname;
            organaisersRow.IDGender = (int)comboBoxGender.SelectedValue;
            organaisersRow.Birthday = dateTimePickerBirth.Value;

            organaisersRow.PhoneNumber = maskedTextBoxPhone.Text;
            organaisersRow.IDEventPlace = Convert.ToInt32(textBoxWorkplace.Text);
            //Подготовка к сохранению фото в БД
            if (pictureBoxPhoto.Image != null)
            {
                MemoryStream stream = new System.IO.MemoryStream();	//Промежуточный поток
                pictureBoxPhoto.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                organaisersRow.Photo = stream.ToArray();
            }
            else
            {
                organaisersRow.Photo = null;
            }
            try
            {
                //Перенести измененные данные в БД
                organaisersTableAdapter1.Update(organaisersRow);
                MessageBox.Show("Ваш профиль обновлен в системе");
                buttonPhotopick.Enabled = false;
                buttonBacktoMenu.Enabled = true;		//Открыт доступ к функционалу бегуна
            }
            catch
            {
                MessageBox.Show("Ошибка при обновлении профиля");
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
            int Eventplaceid = Convert.ToInt32(textBoxWorkplace.Text);
            //Работа с фото
            if (pictureBoxPhoto.Image != null)
            {
                photo = File.ReadAllBytes(openFileDialog1.FileName); //в массив
            }
            try
            {
                //Метод Insert адаптера 
                organaisersTableAdapter1.Insert(firstName, Lastname, idGender, Eventplaceid,  phone, birthday, photo);
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

        private void FormProfileOrganaiser_Load(object sender, EventArgs e)
        {
            //Начальные настройки интерфейса
            buttonAddprofile.Visible = false;
            buttonBacktoMenu.Enabled = true;
            

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
                  

                    break;

                case "ViewEdit":
                    buttonUpdateprofile.Visible = true;
                    org = organaisersTableAdapter1.GetData(); 	//Все данные из таблице Runners
                    //Поиск среди них запись с нужным ID
                    organaisersRow = org.FindByID(ClassforIDUsers.idU);
                    //Перенос данных из записи в элементы интерфейса
                    textBoxWorkplace.Text = organaisersRow.IDEventPlace.ToString();
                    textBoxFirstName.Text = organaisersRow.FirstName;
                    textBoxLastName.Text = organaisersRow.LastName;
                    comboBoxGender.SelectedValue = organaisersRow.IDGender;
                    dateTimePickerBirth.Value = organaisersRow.Birthday;

                    maskedTextBoxPhone.Text = organaisersRow.PhoneNumber;

                    //Получить фото из БД и отобразить его в компоненте
                    if (organaisersRow.IsPhotoNull())		//проверка пустого значения в поле фото
                    {
                        pictureBoxPhoto.Image = Properties.Resources.NotPicture;
                    }
                    else
                    {
                        byte[] photo = organaisersRow.Photo;
                        MemoryStream stream = new MemoryStream(photo);
                        Image bit = Image.FromStream(stream);
                        pictureBoxPhoto.Image = bit;
                    }
                    break;
            }
        }
    }
}
