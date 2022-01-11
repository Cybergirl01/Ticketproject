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
    public partial class FormSeller : Form
    {
        public FormSeller()
        {
            InitializeComponent();
        }
        DBTicketDataSet.SellerDataTable sellers;
        DBTicketDataSet.SellerRow sellerRow;
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonProf_Click(object sender, EventArgs e)
        {
            int ideventplace;
            sellers = this.sellerTableAdapter1.GetData();
            //Ищем профиль того аккаунта, который вошел в систему
            sellerRow = sellers.FindByID(ClassforIDUsers.idU);
            ideventplace = sellerRow.IDEventPlace;
            FormProfileSeller fps = new FormProfileSeller("ViewEdit");
            this.Hide();
            fps.ShowDialog();
            fps.IDEventplace = ideventplace;
            this.Show();
        }

        private void buttonGotosellTicket_Click(object sender, EventArgs e)
        {
            int ideventplace;
            sellers = this.sellerTableAdapter1.GetData();
            //Ищем профиль того аккаунта, который вошел в систему
            sellerRow = sellers.FindByID(ClassforIDUsers.idU);
            ideventplace = sellerRow.IDEventPlace;
            if (ideventplace == 2)
            {
                FormSellingticketsIceSkate fst = new FormSellingticketsIceSkate();
                this.Hide();
                fst.ShowDialog();
                fst.idEventplace = ideventplace;
                this.Show();
            }
            else
            {
                FormSellingTicketsFilms fsf = new FormSellingTicketsFilms();
                this.Hide();
                fsf.ShowDialog();
                fsf.idEventplace = ideventplace;
                this.Show();
            }
        }

        private void FormSeller_Load(object sender, EventArgs e)
        { int ideventplace;
            //Получили все данные
            sellers = this.sellerTableAdapter1.GetData();
            //Ищем профиль того аккаунта, который вошел в систему
            sellerRow = sellers.FindByID(ClassforIDUsers.idU);
            ideventplace = sellerRow.IDEventPlace;
            if (sellerRow == null)
            {
                MessageBox.Show("У вас не заполнен профиль."
                    + Environment.NewLine + "Надо его заполнить для дальнейшей работы");
                //Форма профиля
                FormProfileSeller fps = new FormProfileSeller("Addition");
                this.Hide();
                fps.ShowDialog();
                fps.IDEventplace = ideventplace;
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
