﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bessonova___Tickets
{
    public class TicketBLL
    {
        DBTicketDataSetTableAdapters.TicketsTableAdapter Tick= new DBTicketDataSetTableAdapters.TicketsTableAdapter();
        DBTicketDataSetTableAdapters.SellingTicketTableAdapter selltick = new DBTicketDataSetTableAdapters.SellingTicketTableAdapter();
       


        public DBTicketDataSet.TicketsDataTable ShowTickets()
        {
            return Tick.GetData();
        }


        public void SellTikets(int IDCLI, int idsell, int idtick)
        {
            selltick.Insert(IDCLI, idsell, idtick);
        }

        public void buyingTicket(int eventpl, int room, int row, int place, DateTime actvive, string price, bool inact)
        {
            if (inact == true)
                Tick.Insert(eventpl, room, row, place, actvive, price, inact);
            else
            {
                Tick.Insert(eventpl, room, row, place, actvive, price, inact);
            }
        }




    }
}
