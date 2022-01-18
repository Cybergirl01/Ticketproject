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
    public partial class FormSellingticketsIceSkate : Form
    {
        OrganaiserBLL organaiser = new OrganaiserBLL();
        SellerBLL sell = new SellerBLL();
        DBTicketDataSet.IceSkateEventDataTable iceskate;
        public int idEventplace;
        //ClientsBLL clients = new ClientsBLL();
        //TicketBLL tick = new TicketBLL();  - unused codes
        //TicketDataSet.TicketsDataTable icetick;
        public FormSellingticketsIceSkate()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSellTicket_Click(object sender, EventArgs e)
        {
            int zal, place, rad;
            
            if (comboBoxIce.SelectedItem == null)
            {
                MessageBox.Show("Выберите фильм и клиента!");
            }
            else
            {
                iceskate = organaiser.ShowIceskateEvent();
                for (int i = 0; i < iceskate.Count; i++)
                {
                    if (comboBoxIce.SelectedIndex != 0)
                    {
                        string price = labelSum.Text;
                        zal = (int)numericUpDownZal.Value;
                        place = (int)numericUpDownPlace.Value;
                        rad = (int)numericUpDownRad.Value;

                        bool inact = false;
                        DateTime dateTimeactive = DateTime.Now;

                        sell.SellTicket(idEventplace, zal, rad, place, dateTimeactive, price, inact);
                     

                    }
                }
            }
        }

            private void buttonViewTicket_Click(object sender, EventArgs e)
            {

                FormViewTIcket fvt = new FormViewTIcket("seller");
                this.Hide();
                fvt.ShowDialog();
            fvt.title = (string)comboBoxIce.SelectedItem;
            fvt.viewtime = (TimeSpan)comboBoxTimeview.SelectedItem;
            fvt.place = (int)numericUpDownPlace.Value;
            fvt.price = labelSum.Text;
            fvt.row = (int)numericUpDownRad.Value;
            fvt.room = (int)numericUpDownZal.Value;
            fvt.date = DateTime.Now;
            fvt.IDEventPlace = idEventplace;
            this.Show();
            }


        private void FormSellingticketsIceSkate_Load_1(object sender, EventArgs e)
        {
               this.comboBoxIce.DataSource = organaiser.ShowIceskateEvent();
                this.comboBoxIce.ValueMember = "ID";
                this.comboBoxIce.DisplayMember = "Title";
        }

        private void comboBoxIce_SelectedIndexChanged(object sender, EventArgs e)
        {
            string price;
            iceskate = organaiser.ShowIceskateEvent();
            for (int i = 0; i < iceskate.Count; i++)
            {
                price = iceskate.ElementAt(i).Price;
                labelSum.Text = Convert.ToString(price);
            }
        }
    }
 }

    
   
