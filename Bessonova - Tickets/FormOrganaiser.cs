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
    public partial class FormOrganaiser : Form
    {
        public FormOrganaiser()
        {
            InitializeComponent();
        }
        DBTicketDataSet.OrganaisersDataTable org;
        DBTicketDataSet.OrganaisersRow roworg;
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonProf_Click(object sender, EventArgs e)
        {
            int ideventplace;
            //Получили все данные
            org = this.organaisersTableAdapter1.GetData();
            //Ищем профиль того аккаунта, который вошел в систему
            roworg = org.FindByID(ClassforIDUsers.idU);
            ideventplace = roworg.IDEventPlace;
            FormProfileOrganaiser fpo = new FormProfileOrganaiser("ViewEdit");
            this.Hide();
            fpo.ShowDialog();
            fpo.idEventPlace = ideventplace;
            this.Show();
        }

        private void buttonListof_Click(object sender, EventArgs e)
        {
            int ideventplace;
            //Получили все данные
            org = this.organaisersTableAdapter1.GetData();
            //Ищем профиль того аккаунта, который вошел в систему
            roworg = org.FindByID(ClassforIDUsers.idU);
            ideventplace = roworg.IDEventPlace;
            FormListofEvents listofEvents = new FormListofEvents();
            this.Hide();
            listofEvents.ShowDialog();
            listofEvents.IDEventPlace = ideventplace;
            this.Show();
        }

        private void FormOrganaiser_Load(object sender, EventArgs e)
        {
            int ideventplace;
            //Получили все данные
            org = this.organaisersTableAdapter1.GetData();
            //Ищем профиль того аккаунта, который вошел в систему
            roworg = org.FindByID(ClassforIDUsers.idU);
            ideventplace = roworg.IDEventPlace;
            if (roworg == null)
            {
                MessageBox.Show("У вас не заполнен профиль."
                    + Environment.NewLine + "Надо его заполнить для дальнейшей работы");
                //Форма профиля
                FormProfileOrganaiser fpo = new FormProfileOrganaiser("Addition");
                this.Hide();
                fpo.ShowDialog();
                fpo.idEventPlace = ideventplace;
                this.Show();
            }
            else
            {
                MessageBox.Show("У вас заполнен профиль."
                                    + Environment.NewLine + "Можете работать в системе");
            }
        }
    }
}
