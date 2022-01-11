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
    public partial class FormAutorization : Form
    {
        public FormAutorization()
        {
            InitializeComponent();
        }
        //Таблицы из Базы данных
        DBTicketDataSet.UsersDataTable users;
        DBTicketDataSet.HistoryDataTable histories;
        DBTicketDataSet.HistoryRow history;

        //переменные для таймера
        int TimeLeft;
        int falseentercount = 0;

        //Кнопка закрытия программы
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Кнопка входа в систему
        private void buttonEnter_Click(object sender, EventArgs e)
        { //переменные для логина и пароля
            string log, pas;
            pas = this.textBoxPas.Text;
            log = this.textBoxLog.Text;

            //Данные из таблицы базы данных
            users = this.usersTableAdapter1.GetData();

            //Текущее время
            DateTime dt = DateTime.Now;
            TimeSpan span = dt.TimeOfDay;

            //использование фильтра для нахождения данных
            var filter = users.Where(rec => rec.Email == log && rec.Password == pas);
            if (filter.Count() == 0)
            {
                MessageBox.Show("Таких данных нет.");
                try
                { //Ввод данных в историю
             
                    string actionmessage = "Ошибка входа";
                    historyTableAdapter1.Insert(log, actionmessage, span, false);
                }
                catch
                {
                    MessageBox.Show("Ошибка в истории входа.");
                }
                //подсчет неверных входов
                falseentercount++;
                //Условия
                if (falseentercount >= 3)
                {
                    switch (falseentercount)
                    {
                        case 3:
                            MessageBox.Show("Вы заблокированны в течении 15 сек.");
                            TimeLeft = 15;
                            timeBlock1.Start();

                            break;
                        case 4:
                            MessageBox.Show("Вы заблокированны в течении 20 сек.");
                            TimeLeft = 20;
                            timerBlock2.Start();

                            break;
                        case 5:
                            MessageBox.Show("Вы ввели неверный пароль или логин в третий раз. Программа закрывается.");
                            falseentercount = 0;
                            this.Close();
                            break;
                    }
                }
            }

            else
            {
                try
                { //Ввод данных в историю
                    string actionmessage = "Выполнен вход в систему.";
                    historyTableAdapter1.Insert(log, actionmessage, span, true);
                }
                catch
                {
                    MessageBox.Show("Ошибка в истории входа");
                }

                //Испоользование класса и фильтра для подбора
                ClassforIDUsers.idU = filter.ElementAt(0).ID;
                ClassforIDUsers.idR = filter.ElementAt(0).IDRole;
                ClassforIDUsers.login_Email = filter.ElementAt(0).Email;

                switch (ClassforIDUsers.idR) //определения по IDrole
                {
                    case 4:
                        MessageBox.Show("Добро пожаловать.");
                        FormClient fc = new FormClient();
                        this.Hide();
                        fc.ShowDialog();
                        this.Show();
                        break;
                    case 3:
                        MessageBox.Show("Добрый день, уважаемый продавец.");
                        FormSeller fs = new FormSeller();
                        this.Hide();
                        fs.ShowDialog();
                        this.Show();
                        break;
                    case 2:
                        MessageBox.Show("Вы вошли как организатор.");
                        FormOrganaiser fo = new FormOrganaiser();
                        this.Hide();
                        fo.ShowDialog();
                        this.Show();
                        break;

                    case 1:
                        MessageBox.Show("Вы вошли как администратор.");
                        FormAdmin fa = new FormAdmin();
                        this.Hide();
                        fa.ShowDialog();
                        this.Show();
                        break;

                }

            }
        }

        private void linkLabelForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormCreateNewPassword fCNP = new FormCreateNewPassword();
            fCNP.log = textBoxLog.Text;
            this.Hide();
            fCNP.ShowDialog();
            this.Show();
        }

        private void buttonRegistresion_Click(object sender, EventArgs e)
        {
            FormRegistrationClients fr = new FormRegistrationClients();
            this.Hide();
            fr.ShowDialog();
            this.Show();
        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPass.Checked)
            {
                this.textBoxPas.PasswordChar = (char)0;
            }
            else
            {
                this.textBoxPas.PasswordChar = '*';
            }
        }
    }
}
