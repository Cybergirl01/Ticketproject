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
    public partial class FormMyTicketList : Form
    {
        public FormMyTicketList()
        {
            InitializeComponent();
        }
        //TicketBLL Ticket = new TicketBLL(); - unused code line
        DBTicketDataSet.TicketClientDataTable tickcli;
        
        
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMyTicketList_Load(object sender, EventArgs e)
        {
            ShowList();
        }
        private void ShowList()
        {
            Panel panel;
            Label labelprice, labelRoom, labelid, labelrow, labelplace, labelEventplace, labeltitle;

            tickcli = ticketClientTableAdapter1.GetData();
            if (tickcli.Count == 0)		//Пустой список
            {
                MessageBox.Show("У Вас нет информации о билетах.");

            }
            else
            {
                //Настройка панели FlowLayoutPanel: все записи последовательно спускаются вниз
                this.flowLayoutPanelTicket.FlowDirection = FlowDirection.TopDown;	//свеху
                this.flowLayoutPanelTicket.AutoScroll = true;		//Полосы прокрутки
                this.flowLayoutPanelTicket.WrapContents = false;	//В одной строке
                this.flowLayoutPanelTicket.Font = new Font(FontFamily.GenericMonospace, 12);
                this.flowLayoutPanelTicket.Controls.Clear();
                //Все записи по очереди переносятся в FlowLayoutPanel
                for (int i = 0; i < tickcli.Count; i++)
                {
                    panel = new Panel();		//Контейнер для элементов одной записи
                    panel.Size = new Size(this.flowLayoutPanelTicket.Width, 100);	//Размер

                    //Добавить надпись с Email
                    labelid = new Label();
                    labelid.Location = new Point(5, 70);
                    labelid.Size = new Size(2 * this.flowLayoutPanelTicket.Width / 3, 20);
                    labelid.AutoSize = false;
                    labelid.Text =
                               "ID: " + tickcli.ElementAt(i).ID.ToString();
                    panel.Controls.Add(labelid);         //Добавить надпись в панель
                                                         //Добавить надпись с местом мероприятия
                    labelEventplace = new Label();
                    labelEventplace.Location = new Point(5, 60);
                    labelEventplace.Size = new Size(2 * this.flowLayoutPanelTicket.Width / 3, 20);
                    labelEventplace.AutoSize = false;
                    if (tickcli.ElementAt(i).IDEventPlace == 1)
                    {
                        labelEventplace.Text =
                                 "Место мероприятия: " + "Кинотеатр";

                    }
                    else
                    {
                        labelEventplace.Text =
                                 "Место мероприятия: " + "Ледниковый каток";

                    }
                    panel.Controls.Add(labelEventplace);         //Добавить надпись в панель
                    //Добавить надпись с названием мероприятия
                    labeltitle = new Label();
                    labeltitle.Location = new Point(5, 50);
                    labeltitle.Size = new Size(2 * this.flowLayoutPanelTicket.Width / 3, 20);
                    labeltitle.AutoSize = false;
                    labeltitle.Text =
                               "Название: " + tickcli.ElementAt(i).Title.ToString();
                    panel.Controls.Add(labeltitle);         //Добавить надпись в панель
                    //Добавить надпись с залом
                    labelRoom = new Label();
                    labelRoom.Location = new Point(5, 40);
                    labelRoom.Size = new Size(2 * this.flowLayoutPanelTicket.Width / 3, 20);
                    labelRoom.AutoSize = false;
                    labelRoom.Text =
                               "Зал: " + tickcli.ElementAt(i).Room.ToString();
                    panel.Controls.Add(labelRoom);         //Добавить надпись в панель
                    //Добавить надпись с рядом
                    labelrow = new Label();
                    labelrow.Location = new Point(5, 30);
                    labelrow.Size = new Size(2 * this.flowLayoutPanelTicket.Width / 3, 20);
                    labelrow.AutoSize = false;
                    labelrow.Text =
                               "Ряд: " + tickcli.ElementAt(i).Row.ToString();
                    panel.Controls.Add(labelrow);         //Добавить надпись в панель
                    //Добавить надпись с местом
                    labelplace = new Label();
                    labelplace.Location = new Point(5, 20);
                    labelplace.Size = new Size(2 * this.flowLayoutPanelTicket.Width / 3, 20);
                    labelplace.AutoSize = false;
                    labelplace.Text =
                               "Место: " + tickcli.ElementAt(i).Place.ToString();
                    panel.Controls.Add(labelplace);         //Добавить надпись в панель
                    //Добавить надпись с местом
                    labelprice = new Label();
                    labelprice.Location = new Point(5, 10);
                    labelprice.Size = new Size(2 * this.flowLayoutPanelTicket.Width / 3, 20);
                    labelprice.AutoSize = false;
                    labelprice.Text =
                               "Цена: " + tickcli.ElementAt(i).Price.ToString();
                    panel.Controls.Add(labelprice);         //Добавить надпись в панель
                    //Добавить сформированную панель добавить в FlowLayoutPanel
                    this.flowLayoutPanelTicket.Controls.Add(panel);
                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanelTicket_Paint(object sender, PaintEventArgs e)
        {

        }
    }
   }
    

