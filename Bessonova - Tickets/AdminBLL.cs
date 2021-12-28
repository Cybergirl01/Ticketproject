using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bessonova___Tickets
{ 
    public class AdminBLL
    {
        DBTicketDataSetTableAdapters.HistoryTableAdapter History = new DBTicketDataSetTableAdapters.HistoryTableAdapter();
       
        DBTicketDataSetTableAdapters.UsersTableAdapter Users = new DBTicketDataSetTableAdapters.UsersTableAdapter();

        public DBTicketDataSet.HistoryDataTable ShowHistory()
        {
            return History.GetData();
        }

        public void AddWorkers(string l, string p, int r)
        {
            Users.Insert(l, p, r);

        }

        public DBTicketDataSet.UsersDataTable GetDataofUsers()
        {
            return Users.GetData();
        }


    }
}
