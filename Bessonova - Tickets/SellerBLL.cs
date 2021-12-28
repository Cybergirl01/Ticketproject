using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bessonova___Tickets
{
    public class SellerBLL
    { DBTicketDataSetTableAdapters.SellerTableAdapter sell = new DBTicketDataSetTableAdapters.SellerTableAdapter();
        DBTicketDataSetTableAdapters.UsersTableAdapter Users = new DBTicketDataSetTableAdapters.UsersTableAdapter();
      
        DBTicketDataSet.UsersDataTable userSell = new DBTicketDataSet.UsersDataTable();
        DBTicketDataSet.SellerDataTable sellers = new DBTicketDataSet.SellerDataTable();
        DBTicketDataSet.UsersRow usersRow;
        DBTicketDataSet.SellerRow sellerRow;
        DBTicketDataSetTableAdapters.TicketsTableAdapter tickets = new DBTicketDataSetTableAdapters.TicketsTableAdapter();
   
        public DBTicketDataSet.SellerDataTable showSeller()
        {
            sellers = sell.GetData();
            return sellers;
        }

        public void SellTicket(int eventpl, int room, int row, int place, DateTime actvive, string price, bool inact)
        {if (inact == true)
            tickets.Insert(eventpl, room, row, place, actvive, price, inact);
            else
            {
                tickets.Insert(eventpl, room, row, place, actvive, price, inact);
            }
        }

        public void UpdatePasswordforSellers(string l, string New_pas)
        { //Получение всех записей из таблицы Users
            userSell = this.Users.GetData();
            var filter = userSell.Where(rec => rec.IDRole == 3 && rec.Email == l);
            for (int j = 0; j < filter.Count(); j++)
            {
                usersRow = userSell.ElementAt(j);
                usersRow.Password = New_pas;
                this.Users.Update(usersRow); //Редактировать таблицу
            }
        }
        public void UpdateSeller(string firstname, string lastname, string phone, DateTime birth, int eventpl, int genderid)
        {
            sellers = this.sell.GetData();
            
            var filter = userSell.Where(rec => rec.Email == ClassforIDUsers.login_Email);
            for (int j = 0; j < filter.Count(); j++)
            {
                sellerRow = sellers.ElementAt(j);
                sellerRow.FirstName = firstname;
                sellerRow.LastName = lastname;
                sellerRow.PhoneNumber = phone;
                sellerRow.Birthday = birth;
                sellerRow.IDEventPlace = eventpl;
                sellerRow.IDGender = genderid;

                this.sell.Update(sellerRow); //Редактировать таблицу
            }
        }

    }
}
