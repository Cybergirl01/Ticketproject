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
    public partial class FormAddingEventsFilm : Form
    {
        public FormAddingEventsFilm()
        {
            InitializeComponent();
        }
        OrganaiserBLL organaiserfilm = new OrganaiserBLL();
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonaddfilm_Click(object sender, EventArgs e)
        {
            string titlefilm, price;
            int room, freeplace, idfilm;
            TimeSpan viewtime;
            titlefilm = textBoxName.Text;
            price = textBoxPrice.Text;
            freeplace = Convert.ToInt32(textBoxFreeplaces.Text);
            viewtime = TimeSpan.Parse(textBoxTimeview.Text);
            idfilm = Convert.ToInt32(textBoxIDNum.Text);
            room = Convert.ToInt32(textBoxZal.Text);
            organaiserfilm.AddFilms(idfilm, titlefilm, viewtime, room, freeplace, price);
        }
    }
}
