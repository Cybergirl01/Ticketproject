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
    public partial class FormAddingEventsIceSkate : Form
    {
        public FormAddingEventsIceSkate()
        {
            InitializeComponent();
        }
        OrganaiserBLL organaiserICE = new OrganaiserBLL();
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonaddice_Click(object sender, EventArgs e)
        {
            string titleice, price;
            int room, freeplace;
            TimeSpan viewtime;
            titleice = textBoxName.Text;
            price = textBoxPrice.Text;
            room = Convert.ToInt32(textBoxZal.Text);
            freeplace = Convert.ToInt32(textBoxFreeplaces.Text);
            viewtime = TimeSpan.Parse(textBoxTimeview.Text);
            
            organaiserICE.AddIceskateEvent(titleice, viewtime, room, freeplace, price);
        }
    }
}
