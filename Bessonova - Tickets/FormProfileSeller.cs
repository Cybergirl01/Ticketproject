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
    public partial class FormProfileSeller : Form
    {
        string command;
        public FormProfileSeller(string command)
        {
            InitializeComponent();
            this.command = command;

        }

        DBTicketDataSet.SellerDataTable sellers;
        DBTicketDataSet.SellerRow rowseller;
        SellerBLL sel = new SellerBLL();
        //По таблице Users
        DBTicketDataSet.UsersDataTable dataUsers;	//все данные из таблицы Users
        DBTicketDataSet.UsersRow rowUser;			//Отдельная строка таблицы
        AdminBLL admin = new AdminBLL();
        public int IDEventplace;
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


          
            int idgender = (int)comboBoxGender.SelectedValue;
            birthday = dateTimePickerBirth.Value;

            string PhoneNumber = maskedTextBoxPhone.Text;
            int ideventplace = Convert.ToInt32(textBoxWorkplace.Text);
            //Подготовка к сохранению фото в БД
            if (pictureBoxPhoto.Image != null)
            {
                MemoryStream stream = new System.IO.MemoryStream();	//Промежуточный поток
                pictureBoxPhoto.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                rowseller.Photo = stream.ToArray();
            }
            else
            {
                rowseller.Photo = null;
            }
            try
            {
                //Перенести измененные данные в БД
                sel.UpdateSeller(FirstName,Lastname,PhoneNumber, birthday, ideventplace, idgender);
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
            int idEventPlace = Convert.ToInt32(textBoxWorkplace.Text);
            //Работа с фото
            if (pictureBoxPhoto.Image != null)
            {
                photo = File.ReadAllBytes(openFileDialog1.FileName); //в массив
            }
            try
            {
                //Метод Insert адаптера 
                sellerTableAdapter1.Insert(firstName, Lastname, idGender, birthday, idEventPlace, phone, photo);
                MessageBox.Show("Ваш профиль добавлен в систему");
                buttonAddprofile.Visible = false;
                buttonPhotopick.Enabled = false;
                buttonBacktoMenu.Enabled = true;		//доступ к функционалу бегуна
            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении профиля");
            }
        }

        private void FormProfileSeller_Load(object sender, EventArgs e)
        {
            //Начальные настройки интерфейса
            buttonAddprofile.Visible = false;
            buttonBacktoMenu.Enabled = true;
           

            openFileDialog1.Filter = "jpg|*.jpg|png|*.png";
            //Данные из таблицы Users, которые нельзя менять
            dataUsers = admin.GetDataofUsers();
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
                    sellers = sel.showSeller(); 	//Все данные из таблице Runners
                    //Поиск среди них запись с нужным ID
                    rowseller = sellers.FindByID(ClassforIDUsers.idU);
                    //Перенос данных из записи в элементы интерфейса
                    
                    textBoxFirstName.Text = rowseller.FirstName;
                    textBoxLastName.Text = rowseller.LastName;
                    comboBoxGender.SelectedValue = rowseller.IDGender;
                    dateTimePickerBirth.Value = rowseller.Birthday;

                    maskedTextBoxPhone.Text = rowseller.PhoneNumber;
                    textBoxWorkplace.Text = Convert.ToString(rowseller.IDEventPlace);
                    //Получить фото из БД и отобразить его в компоненте
                    if (rowseller.IsPhotoNull())		//проверка пустого значения в поле фото
                    {
                        pictureBoxPhoto.Image = Properties.Resources.NotPicture;
                    }
                    else
                    {
                        byte[] photo = rowseller.Photo;
                        MemoryStream stream = new MemoryStream(photo);
                        Image bit = Image.FromStream(stream);
                        pictureBoxPhoto.Image = bit;
                    }
                    break;
            }
        }
    }
}
