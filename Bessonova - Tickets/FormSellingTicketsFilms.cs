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
    public partial class FormSellingTicketsFilms : Form
    {
        public int idEventplace;
        public FormSellingTicketsFilms()
        {
            InitializeComponent();
        }
       
        OrganaiserBLL organaiser = new OrganaiserBLL();
        SellerBLL sell = new SellerBLL();
        DBTicketDataSet.SellerDataTable sel;
        DBTicketDataSet.SellerRow rowseller;
        DBTicketDataSet.FilmsDataTable filmslist;
       // TicketBLL ticket = new TicketBLL(); - unused
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormSellingTicketsFilms_Load(object sender, EventArgs e)
        {

           this.comboBoxFilm.DataSource = organaiser.ShowFilms();
            this.comboBoxFilm.ValueMember = "ID";
            this.comboBoxFilm.DisplayMember = "Title";


        }

        private void buttonViewTicket_Click(object sender, EventArgs e)
        {   
            
            FormViewTIcket fvt = new FormViewTIcket("seller");
            this.Hide();
            fvt.ShowDialog();
            fvt.filmname = (string)comboBoxFilm.SelectedItem;
            fvt.place = (int)numericUpDownPlace.Value;
            fvt.price = labelSum.Text;
            fvt.row = (int)numericUpDownRad.Value;
            fvt.room = (int)numericUpDownZal.Value;
            fvt.date = DateTime.Now;
            fvt.viewtime = (TimeSpan)comboBoxTimeview.SelectedItem;
            fvt.IDEventPlace = idEventplace;
            this.Show();
        }

        private void buttonSellTicket_Click(object sender, EventArgs e)
        {
            int zal, place, rad;
            
            if (comboBoxFilm.SelectedItem == null)
            {
                MessageBox.Show("Выберите фильм!");
            }
            else
            {
                filmslist = organaiser.ShowFilms();
                for (int i = 0; i < filmslist.Count; i++)
                {if (comboBoxFilm.SelectedItem != null)
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
        private void comboBoxFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            string price;
            filmslist = organaiser.ShowFilms();
            for (int i = 0; i < filmslist.Count; i++)
            {
                price = filmslist.ElementAt(i).Price;
                labelSum.Text = Convert.ToString(price);
            }
        }
    }
}
