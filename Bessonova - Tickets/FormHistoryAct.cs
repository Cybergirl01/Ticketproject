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
    public partial class FormHistoryAct : Form
    {
        public FormHistoryAct()
        {
            InitializeComponent();
        }
        
        AdminBLL adminBLL = new AdminBLL();
        private void FormHistoryAct_Load(object sender, EventArgs e)
        {
             
            this.dataGridViewHistory.DataSource = adminBLL.ShowHistory(); 
            this.dataGridViewHistory.Columns["ID"].Visible = false;
            this.dataGridViewHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHistory.AllowUserToAddRows = false;

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.comboBoxFilter.Text)
            {
                case "Все":
                    this.dataGridViewhis.DataSource = adminBLL.ShowHistory(); ;

                    break;
                case "Успешные":
                    var filterTrue = adminBLL.ShowHistory().Where(rec => rec.Result == true);
                    this.dataGridViewhis.DataSource = filterTrue.CopyToDataTable();

                    break;
                case "Неуспешные":
                    var filterFalse = adminBLL.ShowHistory().Where(rec => rec.Result == false);
                    this.dataGridViewhis.DataSource = filterFalse.CopyToDataTable();

                    break;
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchString = this.textBoxSearch.Text;
            var filter = adminBLL.ShowHistory().Where(rec => rec.Login.Contains(searchString));
            if (filter.Count() != 0)
            {
                this.dataGridViewhis.DataSource = filter.CopyToDataTable();
                this.dataGridViewhis.Columns["ID"].Visible = false;
            }
            else
            {
                this.dataGridViewhis.DataSource = null;
            }
        }
    }
}
