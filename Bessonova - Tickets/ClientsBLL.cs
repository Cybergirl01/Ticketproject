using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bessonova___Tickets
{
    public class ClientsBLL
    {
        DBTicketDataSetTableAdapters.UsersTableAdapter Users = new DBTicketDataSetTableAdapters.UsersTableAdapter();
        DBTicketDataSetTableAdapters.ClientTableAdapter Cli = new DBTicketDataSetTableAdapters.ClientTableAdapter();
        DBTicketDataSet.UsersDataTable userCli = new DBTicketDataSet.UsersDataTable();
        DBTicketDataSet.ClientDataTable clients = new DBTicketDataSet.ClientDataTable();
        DBTicketDataSet.UsersRow usersRow;
        DBTicketDataSet.ClientRow ClientRow;
       
        public void RegisterClient(string l, string p)
        {
            int idroleClient = 4;
            Users.Insert(l, p, idroleClient);

        }

        public void UpdatePassword(string l, string New_pas)
        { //Получение всех записей из таблицы Users
            userCli = this.Users.GetData();
            var filter = userCli.Where(rec => rec.IDRole == 4 && rec.Email == l);
            for (int j = 0; j < filter.Count(); j++)
            {
                usersRow = userCli.ElementAt(j);
                usersRow.Password = New_pas;
                this.Users.Update(usersRow); //Редактировать таблицу
            }
        }

        public DBTicketDataSet.ClientDataTable GetDataofclient()
        {
            return Cli.GetData();
        }

        public void UpdateClient(string firstname, string lastname, string phone, DateTime birth, int genderid)
        {
            userCli = this.Users.GetData();
            clients = this.Cli.GetData();
            var filter = userCli.Where(rec => rec.Email == ClassforIDUsers.login_Email);
            for (int j = 0; j < filter.Count(); j++)
            {
                ClientRow = clients.ElementAt(j);
                ClientRow.FirstName = firstname;
                ClientRow.LastName = lastname;
                ClientRow.PhoneNumber = phone;
                ClientRow.Birthday = birth;
                ClientRow.IDGender = genderid;
         
                
                this.Cli.Update(ClientRow); //Редактировать таблицу
            }
        }

    }
}
