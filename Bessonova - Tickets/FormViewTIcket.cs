using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;

namespace Bessonova___Tickets
{
    public partial class FormViewTIcket : Form
    {
        string commandclient_seller;
        public string filmname;
        public int room, row, place;
        public string price;
        public DateTime date;
        public string nameclient;
        public int IDSeller;
        public int IDEventPlace;
        public string title; 

        public FormViewTIcket(string commandclient_seller)
        {
            InitializeComponent();
            this.commandclient_seller = commandclient_seller;

        }
        ClientsBLL Clientsbll = new ClientsBLL();
        DBTicketDataSet.ClientProfDataTable clients;
        TicketBLL tickets = new TicketBLL();
        DBTicketDataSet.ClientProfRow ClientProfRow;
        DBTicketDataSet.TicketsDataTable ticket;
        DBTicketDataSet.TicketsRow rowticket;
        DBTicketDataSet.FilmTicketsDataTable filmTickets;
        DBTicketDataSet.FilmTicketsRow FilmTicketsRow;

        private void buttonQRCode_Click(object sender, EventArgs e)
        {
            string qrtext = richTextBoxTicket.Text; //считываем текст из RichTextBox'a
            QRCodeEncoder encoder = new QRCodeEncoder(); //создаем объект класса QRCodeEncoder
            Bitmap qrcode = encoder.Encode(qrtext); // кодируем слово, полученное из TextBox'a (qrtext) в переменную qrcode. класса Bitmap(класс, который используется для работы с изображениями)
            pictureBoxQR.Image = qrcode as Image; // pictureBox выводит qrcode как изображение.
        }



        private void buttonSaveQRCode_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog(); // save будет запрашивать у пользователя, место, в которое он захочет сохранить файл. 
            save.Filter = "PNG|*.png|JPEG|*.jpg|GIF|*.gif|BMP|*.bmp"; //создаём фильтр, который определяет, в каких форматах мы сможем сохранить нашу информацию. В данном случае выбираем форматы изображений. Записывается так: "название_формата_в обозревателе|*.расширение_формата")
            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK) //если пользователь нажимает в обозревателе кнопку "Сохранить".
            {
                pictureBoxQR.Image.Save(save.FileName); //изображение из pictureBox'a сохраняется под именем, которое введёт пользователь
            }
        }

        private void buttonGotoAutorization_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["FormAutorization"].Show();	//Сразу на форму авторизации
        }

        private void FormViewTIcketforclient_Load(object sender, EventArgs e)
        {
            switch (commandclient_seller)
            {
                case "seller":
                    if (IDEventPlace == 1)
                    {
                      

                        richTextBoxTicket.AppendText("Билет: " + Environment.NewLine);
                    }
                    else
                    {

                    }
                        break;

                case "client":
                    if (IDEventPlace == 1)
                    {

                        clients = clientProfTableAdapter1.GetData();
                        ClientProfRow = clients.FindByID(ClassforIDUsers.idU);
                        string Clientfirstname = ClientProfRow.FirstName;
                        string ClientLastname = ClientProfRow.LastName;


                        richTextBoxTicket.AppendText("Имя: " + Clientfirstname + Environment.NewLine);
                        richTextBoxTicket.AppendText("Отчество: " + Clientfirstname + Environment.NewLine);

                        richTextBoxTicket.AppendText("Билет: " + Environment.NewLine);
                        richTextBoxTicket.AppendText("Название: " + title + Environment.NewLine);
                    }
                    else 
                    {

                    }
                    break;
            }
        }

       
    }
}
