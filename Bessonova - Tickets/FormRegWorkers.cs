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
    public partial class FormRegWorkers : Form
    {
        public FormRegWorkers()
        {
            InitializeComponent();
        }
        DBTicketDataSet.UsersDataTable dataUsers;
        AdminBLL adminBLL = new AdminBLL();

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            this.groupBoxWorkeracc.Enabled = true;	//Доступно для изменения
            textBoxLogin.Text = "";
            textBoxPassword.Text = "";
            this.buttonInsert.Enabled = true;		//Разблокировано внесение изменений
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            string log = textBoxLogin.Text;
            string pas = textBoxPassword.Text;
            //Контроль корректности заполнения полей
            if (String.IsNullOrEmpty(log) || String.IsNullOrEmpty(pas))
            {
                MessageBox.Show("Не все поля заполнены");
                return;
            }
            int pos = log.IndexOf('@');
            if (pos < 0)
            {
                MessageBox.Show("В логине отсутствуют обязательный символ @");
                return;
            }
            pos = log.IndexOf('.');
            if (pos < 0)
            {
                MessageBox.Show("В логине отсутствуют обязательный символ .");
                return;
            }
            int paslength = pas.Length;
            if (paslength < 6)
            {
                MessageBox.Show("В пароле должно быть не менее 6 символов.");
                return;
            }
            string pass = pas;
            for (int i = 0; i < pass.Length; ++i)
            {
                if (!char.IsLetter(pass[i]))
                {
                    MessageBox.Show("В пароле должны содержатся только латинские буквы, цифры.");
                    return;
                }
            }



            if ((int)comboBoxRoles.SelectedValue == 1 || (int)comboBoxRoles.SelectedValue == 4)
            {
                MessageBox.Show("Нельзя добавлять нового администратора или клиента."
                    + Environment.NewLine + "Выберите другою роль");
                return;
            }
            //Поиск совпадений по данным
            var filter = dataUsers.Where(rec => rec.Email == log && rec.Password == pas);
            if (filter.Count() == 0)	//Нет записей – совпадение логина+пароля не найдено
            {
                try
                {
                    adminBLL.AddWorkers(log, pas, (int)comboBoxRoles.SelectedValue);
                    MessageBox.Show("Данные о новом пользователе успешно сохранены в БД");
                    FormRegWorkers_Load(null, null);		//Обновить данные в таблице
                }
                catch
                {
                    MessageBox.Show("При добавлении нового пользователя возникли проблемы");
                    return;
                }
            }
            else				//Данные в БД есть
            {
                MessageBox.Show("Такой пользователь уже зарегистрирован в системе." +
                                                    Environment.NewLine + " Введите другие данные");
                return;
            }
        }

        private void FormRegWorkers_Load(object sender, EventArgs e)
        {
            //Получение всех записей из таблицы Users
            dataUsers = adminBLL.GetDataofUsers();
            //Отбор только с ролью продавца и клиента
            var filter = dataUsers.Where(rec => rec.IDRole == 2 || rec.IDRole == 3);
            //Количество записей
            int totalCount = filter.Count();
            //Отобразить полученные записи в компоненте
            this.dataGridViewAccounts.DataSource = filter.CopyToDataTable();
            //Выделять всю строку
            this.dataGridViewAccounts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAccounts.Select();		//Выбрать первую строку
            //Настроить список ролей в ComboBox
            this.comboBoxRoles.DataSource = this.rolesTableAdapter1.GetData();
            this.comboBoxRoles.DisplayMember = "Title";	//Видеть
            this.comboBoxRoles.ValueMember = "ID";		//Получить
            this.groupBoxWorkeracc.Enabled = false;		//Недоступно для изменения
            this.buttonInsert.Enabled = false;			//Заблокировано внесение изменений
        }

        private void dataGridViewAccounts_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int numRow = e.RowIndex;				//Получить номер выбранной строки
            //Отобразить в контейнере значения нужных полей
            textBoxLogin.Text = dataGridViewAccounts.Rows[numRow].Cells[1].Value.ToString();
            textBoxPassword.Text = dataGridViewAccounts.Rows[numRow].Cells[2].Value.ToString();
            //Отобразить название роли по ее номеру
            comboBoxRoles.SelectedValue = (int)dataGridViewAccounts.Rows[numRow].Cells[3].Value;
        }
    }
}

