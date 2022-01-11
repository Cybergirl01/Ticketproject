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
    public partial class FormListofUsers : Form
    {
        public FormListofUsers()
        {
            InitializeComponent();
        }
        AdminBLL adminBLL = new AdminBLL();
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMore_Click(object sender, EventArgs e)
        {
            FormMoreinfoUserslist moreinfoUserslist = new FormMoreinfoUserslist();
            this.Hide();
            moreinfoUserslist.ShowDialog();
            this.Show();
        }

        private void FormListofUsers_Load(object sender, EventArgs e)
        {
            
            this.dataGridViewlist.DataSource = adminBLL.GetDataofUsers();
            this.dataGridViewlist.Columns["ID"].Visible = false;
            this.dataGridViewlist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewlist.AllowUserToAddRows = false;
        }
    }
}
