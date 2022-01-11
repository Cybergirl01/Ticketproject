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
    public partial class FormSelectPlaceEvent : Form
    {
        public FormSelectPlaceEvent()
        {
            InitializeComponent();
        }

        private void buttonIceSkate_Click(object sender, EventArgs e)
        {
            int IDSkateEvent = 2;
            FormBuyingTicketsIceSkate fbtice = new FormBuyingTicketsIceSkate();
            this.Hide();
            fbtice.ShowDialog();
            this.Show();
        }

        private void buttonFilm_Click(object sender, EventArgs e)
        {
            int IDFilmEvent = 1;
            FormBuyingTicketsFilm fbtfilm = new FormBuyingTicketsFilm();
            this.Hide();
            fbtfilm.ShowDialog();
            this.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
