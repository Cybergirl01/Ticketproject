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
    public partial class FormListofEvents : Form
    {
        public int IDEventPlace;
        DBTicketDataSet.FilmsDataTable film;
        DBTicketDataSet.IceSkateEventDataTable ice;
        public FormListofEvents()
        {
            InitializeComponent();
        }
        OrganaiserBLL organaiser = new OrganaiserBLL();
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void FormListofEvents_Load(object sender, EventArgs e)
        {if (IDEventPlace == 1)
            {
                film = this.organaiser.ShowFilms();
                this.dataGridViewEvents.DataSource = film;
                this.dataGridViewEvents.Columns["ID"].Visible = false;
                this.dataGridViewEvents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                this.dataGridViewEvents.AllowUserToAddRows = false;
            }
            else
            {
                ice = this.organaiser.ShowIceskateEvent();
                this.dataGridViewEvents.DataSource = ice;
                this.dataGridViewEvents.Columns["ID"].Visible = false;
                this.dataGridViewEvents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                this.dataGridViewEvents.AllowUserToAddRows = false;
            }
            

        }

        private void buttonAddevent_Click(object sender, EventArgs e)
        {
            if(IDEventPlace == 1)
            {
                FormAddingEventsFilm addfilm = new FormAddingEventsFilm();
                this.Hide();
                addfilm.ShowDialog();
                this.Show();
            }
            else
            {
                FormAddingEventsIceSkate addice = new FormAddingEventsIceSkate();
                this.Hide();
                addice.ShowDialog();
                this.Show();
            }
        }
    }
}
