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
    }
}
