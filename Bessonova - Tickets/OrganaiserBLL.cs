using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bessonova___Tickets
{
    public class OrganaiserBLL
    {
        DBTicketDataSetTableAdapters.FilmsTableAdapter film = new DBTicketDataSetTableAdapters.FilmsTableAdapter();
        DBTicketDataSetTableAdapters.IceSkateEventTableAdapter ice = new DBTicketDataSetTableAdapters.IceSkateEventTableAdapter();

        public void AddFilms(int idfilm, string tit, TimeSpan time, int room, int place, string price)
        {
            film.Insert(idfilm, tit, time, room, place, price);
        }
        public void AddIceskateEvent(string tit, TimeSpan time, int room, int place, string price)
        {
            ice.Insert(tit, time, room, place, price);
        }

        public DBTicketDataSet.IceSkateEventDataTable ShowIceskateEvent()
        {
            return ice.GetData();
        }

        public DBTicketDataSet.FilmsDataTable ShowFilms()
        {
            return film.GetData();
        }
    }
}
