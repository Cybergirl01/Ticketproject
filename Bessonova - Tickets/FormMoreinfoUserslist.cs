using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bessonova___Tickets
{
    public partial class FormMoreinfoUserslist : Form
    {
        public FormMoreinfoUserslist()
        {
            InitializeComponent();
        }
        AdminBLL admin = new AdminBLL();
        DBTicketDataSet.UsersDataTable users;
        ClientsBLL Clients = new ClientsBLL();
        DBTicketDataSet.ClientDataTable cli = new DBTicketDataSet.ClientDataTable();
        DBTicketDataSetTableAdapters.OrganaisersTableAdapter OrganaisersTableAdapter = new DBTicketDataSetTableAdapters.OrganaisersTableAdapter();
        DBTicketDataSet.OrganaisersDataTable org = new DBTicketDataSet.OrganaisersDataTable();
        DBTicketDataSet.SellerDataTable sel = new DBTicketDataSet.SellerDataTable();
        SellerBLL Seller = new SellerBLL();
        DBTicketDataSet.RolesDataTable roles;
        DBTicketDataSet.EventPlaceDataTable EventPlaces;

        private void ShowList()
        {
            Panel panel1, panel2, panel3, panel4;
            Label labelName, labelLastname, labelEmail, labelrole, labelPhone, labelEventplace;
            PictureBox pictureBoxcli, pictureBoxSel, pictureBoxorg;
            byte[] photo, photo2, photo3;
            System.IO.MemoryStream stream, stream2, stream3;
            Bitmap bit, bit2, bit3, bitNot;
            bitNot = new Bitmap(Properties.Resources.NotPicture);   //Для пустой картинки

            sel = Seller.showSeller();
            users = admin.GetDataofUsers();
            cli = Clients.GetDataofclient();
            org = OrganaisersTableAdapter.GetData();

            if (users.Count == 0 && cli.Count == 0 && org.Count == 0 && sel.Count == 0)		//Пустой список
            {
                MessageBox.Show("У Вас нет информации о пользователях.");
                
            }
            else
            {
                //Настройка панели FlowLayoutPanel: все записи последовательно спускаются вниз
                this.flowLayoutPanelInfousers.FlowDirection = FlowDirection.TopDown;	//свеху
                this.flowLayoutPanelInfousers.AutoScroll = true;		//Полосы прокрутки
                this.flowLayoutPanelInfousers.WrapContents = false;	//В одной строке
                this.flowLayoutPanelInfousers.Font = new Font(FontFamily.GenericMonospace, 12);
                this.flowLayoutPanelInfousers.Controls.Clear();
                //Все записи по очереди переносятся в FlowLayoutPanel
                for (int i = 0; i < users.Count; i++)
                {
                    panel1 = new Panel();		//Контейнер для элементов одной записи
                    panel1.Size = new Size(this.flowLayoutPanelInfousers.Width, 100);	//Размер

                    //Добавить надпись с Email
                    labelEmail = new Label();
                    labelEmail.Location = new Point(5, 70);
                    labelEmail.Size = new Size(2 * this.flowLayoutPanelInfousers.Width / 3, 20);
                    labelEmail.AutoSize = false;
                    labelEmail.Text =
                               "Email: " + users.ElementAt(i).Email.ToString();
                    panel1.Controls.Add(labelEmail);         //Добавить надпись в панель
                                                            //Добавить надпись с ролью
                    labelrole = new Label();
                    labelrole.Location = new Point(5, 50);
                    labelrole.Size = new Size(2 * this.flowLayoutPanelInfousers.Width / 3, 20);
                    labelrole.AutoSize = false;
                    for (int j = 0; j < roles.Count; j++)
                    {
                        if (roles.ElementAt(j).ID == users.ElementAt(i).IDRole)
                            labelrole.Text =
                                       "Роль: " + roles.ElementAt(j).Role;
                        else
                            labelrole.Text =
                                                                 "Роль: " + roles.ElementAt(j).Role;
                        panel1.Controls.Add(labelrole);         //Добавить надпись в панель
                    }
                    //Добавить сформированную панель добавить в FlowLayoutPanel
                    this.flowLayoutPanelInfousers.Controls.Add(panel1);
                }
                //Клиент
                //Настройка панели FlowLayoutPanel: все записи последовательно спускаются вниз
                this.flowLayoutPanelClient.FlowDirection = FlowDirection.TopDown;	//свеху
                this.flowLayoutPanelClient.AutoScroll = true;		//Полосы прокрутки
                this.flowLayoutPanelClient.WrapContents = false;	//В одной строке
                this.flowLayoutPanelClient.Font = new Font(FontFamily.GenericMonospace, 12);
                this.flowLayoutPanelClient.Controls.Clear();
                //Все записи по очереди переносятся в FlowLayoutPanel
                for (int i1 = 0; i1 < cli.Count; i1++)
                {
                    panel2 = new Panel();		//Контейнер для элементов одной записи
                    panel2.Size = new Size(this.flowLayoutPanelClient.Width, 100);	//Размер
                    //Настройка фото 
                    pictureBoxcli = new PictureBox();
                    pictureBoxcli.Size = new Size(panel2.Width / 3, panel2.Height - 10);
                    pictureBoxcli.Location = new Point(5, 5);
                    pictureBoxcli.BorderStyle = BorderStyle.Fixed3D;
                    pictureBoxcli.SizeMode = PictureBoxSizeMode.Zoom;
                    //Работа с фото
                    if (cli.ElementAt(i1).IsPhotoNull())
                    {
                        pictureBoxcli.Image = bitNot;    //Изображение без фото
                    }
                    else
                    {
                        photo = cli.ElementAt(i1).Photo;	//Значение поля фото
                        stream = new System.IO.MemoryStream(photo);
                        bit = (Bitmap)Image.FromStream(stream);
                        pictureBoxcli.Image = bit;				//Для отображения
                    }
                    panel2.Controls.Add(pictureBoxcli);	//Добавить картинку в панель
                    //Добавить надпись с именем 
                    labelName = new Label();
                    labelName.Location = new Point(pictureBoxcli.Size.Width + 5, 20);
                    labelName.Size = new Size(2 * this.flowLayoutPanelClient.Width / 3, 20);
                    labelName.AutoSize = false;
                    labelName.Text = "Имя: " + cli.ElementAt(i1).FirstName;
                    panel2.Controls.Add(labelName);		//Добавить надпись в панель
                    //Добавить надпись с фамилией 
                    labelLastname = new Label();
                    labelLastname.Location = new Point(pictureBoxcli.Size.Width + 5, 45);
                    labelLastname.Size = new Size(2 * this.flowLayoutPanelClient.Width / 3, 20);
                    labelLastname.AutoSize = false;
                    labelLastname.Text = "Фамилия: " + cli.ElementAt(i1).LastName;
                    panel2.Controls.Add(labelLastname);		//Добавить надпись в панель
                    //Добавить надпись с телефон
                    labelPhone = new Label();
                    labelPhone.Location = new Point(pictureBoxcli.Size.Width + 5, 70);
                    labelPhone.Size = new Size(2 * this.flowLayoutPanelClient.Width / 3, 20);
                    labelPhone.AutoSize = false;
                    labelPhone.Text =
                               "Телефон: " + cli.ElementAt(i1).PhoneNumber.ToString();
                    panel2.Controls.Add(labelPhone);			//Добавить надпись в панель
                    //Добавить сформированную панель добавить в FlowLayoutPanel
                    this.flowLayoutPanelClient.Controls.Add(panel2);
                }
                //Продавец
                //Настройка панели FlowLayoutPanel: все записи последовательно спускаются вниз
                this.flowLayoutPanelSeller.FlowDirection = FlowDirection.TopDown;	//свеху
                this.flowLayoutPanelSeller.AutoScroll = true;		//Полосы прокрутки
                this.flowLayoutPanelSeller.WrapContents = false;	//В одной строке
                this.flowLayoutPanelSeller.Font = new Font(FontFamily.GenericMonospace, 12);
                this.flowLayoutPanelSeller.Controls.Clear();
                //Все записи по очереди переносятся в FlowLayoutPanel
                for (int i2 = 0; i2 < sel.Count; i2++)
                {
                    panel3 = new Panel();		//Контейнер для элементов одной записи
                    panel3.Size = new Size(this.flowLayoutPanelSeller.Width, 100);	//Размер
                    //Настройка фото 
                    pictureBoxSel = new PictureBox();
                    pictureBoxSel.Size = new Size(panel3.Width / 3, panel3.Height - 10);
                    pictureBoxSel.Location = new Point(5, 5);
                    pictureBoxSel.BorderStyle = BorderStyle.Fixed3D;
                    pictureBoxSel.SizeMode = PictureBoxSizeMode.Zoom;
                    //Работа с фото
                    if (sel.ElementAt(i2).IsPhotoNull())
                    {
                        pictureBoxSel.Image = bitNot;    //Изображение без фото
                    }
                    else
                    {
                        photo2 = sel.ElementAt(i2).Photo;	//Значение поля фото
                        stream2 = new System.IO.MemoryStream(photo2);
                        bit2 = (Bitmap)Image.FromStream(stream2);
                        pictureBoxSel.Image = bit2;				//Для отображения
                    }
                    panel3.Controls.Add(pictureBoxSel);	//Добавить картинку в панель
                    //Добавить надпись с именем 
                    labelName = new Label();
                    labelName.Location = new Point(pictureBoxSel.Size.Width + 5, 20);
                    labelName.Size = new Size(2 * this.flowLayoutPanelSeller.Width / 3, 20);
                    labelName.AutoSize = false;
                    labelName.Text = "Имя: " + sel.ElementAt(i2).FirstName;
                    panel3.Controls.Add(labelName);		//Добавить надпись в панель
                    //Добавить надпись с фамилией 
                    labelLastname = new Label();
                    labelLastname.Location = new Point(pictureBoxSel.Size.Width + 5, 45);
                    labelLastname.Size = new Size(2 * this.flowLayoutPanelSeller.Width / 3, 20);
                    labelLastname.AutoSize = false;
                    labelLastname.Text = "Фамилия: " + sel.ElementAt(i2).LastName;
                    panel3.Controls.Add(labelLastname);		//Добавить надпись в панель
                    //Добавить надпись с телефон
                    labelPhone = new Label();
                    labelPhone.Location = new Point(pictureBoxSel.Size.Width + 5, 70);
                    labelPhone.Size = new Size(2 * this.flowLayoutPanelSeller.Width / 3, 20);
                    labelPhone.AutoSize = false;
                    labelPhone.Text =
                               "Телефон: " + sel.ElementAt(i2).PhoneNumber.ToString();
                    panel3.Controls.Add(labelPhone);            //Добавить надпись в панель
                                                                //Добавить надпись с местом мероприятия
                    labelEventplace = new Label();
                    labelEventplace.Location = new Point(pictureBoxSel.Size.Width + 5, 70);
                    labelEventplace.Size = new Size(2 * this.flowLayoutPanelSeller.Width / 3, 20);
                    labelEventplace.AutoSize = false;
                    for (int j1 = 0; j1 < EventPlaces.Count; j1++)
                    {
                        if (EventPlaces.ElementAt(j1).ID == sel.ElementAt(i2).IDEventPlace)
                            labelEventplace.Text =
                                       "Место мероприятия: " + EventPlaces.ElementAt(j1).Title;
                        else
                            labelEventplace.Text =
                                                                 "Место мероприятия: " + EventPlaces.ElementAt(j1).Title;
                     
                    }
                    panel3.Controls.Add(labelEventplace);         //Добавить надпись в панель
                 
                    //Добавить сформированную панель добавить в FlowLayoutPanel
                    this.flowLayoutPanelSeller.Controls.Add(panel3);
                }
                //Организатор
                //Настройка панели FlowLayoutPanel: все записи последовательно спускаются вниз
                this.flowLayoutPanelOrganaisers.FlowDirection = FlowDirection.TopDown;	//свеху
                this.flowLayoutPanelOrganaisers.AutoScroll = true;		//Полосы прокрутки
                this.flowLayoutPanelOrganaisers.WrapContents = false;	//В одной строке
                this.flowLayoutPanelOrganaisers.Font = new Font(FontFamily.GenericMonospace, 12);
                this.flowLayoutPanelOrganaisers.Controls.Clear();
                //Все записи по очереди переносятся в FlowLayoutPanel
                for (int i3 = 0; i3 < sel.Count; i3++)
                {
                    panel4 = new Panel();		//Контейнер для элементов одной записи
                    panel4.Size = new Size(this.flowLayoutPanelOrganaisers.Width, 100);	//Размер
                    //Настройка фото 
                    pictureBoxorg = new PictureBox();
                    pictureBoxorg.Size = new Size(panel4.Width / 3, panel4.Height - 10);
                    pictureBoxorg.Location = new Point(5, 5);
                    pictureBoxorg.BorderStyle = BorderStyle.Fixed3D;
                    pictureBoxorg.SizeMode = PictureBoxSizeMode.Zoom;
                    //Работа с фото
                    if (sel.ElementAt(i3).IsPhotoNull())
                    {
                        pictureBoxorg.Image = bitNot;    //Изображение без фото
                    }
                    else
                    {
                        photo3 = sel.ElementAt(i3).Photo;	//Значение поля фото
                        stream3 = new System.IO.MemoryStream(photo3);
                        bit3 = (Bitmap)Image.FromStream(stream3);
                        pictureBoxorg.Image = bit3;				//Для отображения
                    }
                    panel4.Controls.Add(pictureBoxorg);	//Добавить картинку в панель
                    //Добавить надпись с именем 
                    labelName = new Label();
                    labelName.Location = new Point(pictureBoxorg.Size.Width + 5, 20);
                    labelName.Size = new Size(2 * this.flowLayoutPanelOrganaisers.Width / 3, 20);
                    labelName.AutoSize = false;
                    labelName.Text = "Имя: " + sel.ElementAt(i3).FirstName;
                    panel4.Controls.Add(labelName);		//Добавить надпись в панель
                    //Добавить надпись с фамилией 
                    labelLastname = new Label();
                    labelLastname.Location = new Point(pictureBoxorg.Size.Width + 5, 45);
                    labelLastname.Size = new Size(2 * this.flowLayoutPanelOrganaisers.Width / 3, 20);
                    labelLastname.AutoSize = false;
                    labelLastname.Text = "Фамилия: " + sel.ElementAt(i3).LastName;
                    panel4.Controls.Add(labelLastname);		//Добавить надпись в панель
                    //Добавить надпись с телефон
                    labelPhone = new Label();
                    labelPhone.Location = new Point(pictureBoxorg.Size.Width + 5, 70);
                    labelPhone.Size = new Size(2 * this.flowLayoutPanelOrganaisers.Width / 3, 20);
                    labelPhone.AutoSize = false;
                    labelPhone.Text =
                               "Телефон: " + sel.ElementAt(i3).PhoneNumber.ToString();
                    panel4.Controls.Add(labelPhone);            //Добавить надпись в панель
                                                                //Добавить надпись с местом мероприятия
                    labelEventplace = new Label();
                    labelEventplace.Location = new Point(pictureBoxorg.Size.Width + 5, 70);
                    labelEventplace.Size = new Size(2 * this.flowLayoutPanelOrganaisers.Width / 3, 20);
                    labelEventplace.AutoSize = false;
                    for (int j2 = 0; j2 < EventPlaces.Count; j2++)
                    {
                        if (EventPlaces.ElementAt(j2).ID == sel.ElementAt(i3).IDEventPlace)
                            labelEventplace.Text =
                                       "Место мероприятия: " + EventPlaces.ElementAt(j2).Title;
                        else
                            labelEventplace.Text =
                                                                 "Место мероприятия: " + EventPlaces.ElementAt(j2).Title;

                    }
                    panel4.Controls.Add(labelEventplace);         //Добавить надпись в панель

                    //Добавить сформированную панель добавить в FlowLayoutPanel
                    this.flowLayoutPanelOrganaisers.Controls.Add(panel4);
                }


            }
        }

        private void FormMoreinfoUserslist_Load(object sender, EventArgs e)
        {
            ShowList();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
