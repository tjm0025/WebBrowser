using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBroswer.Logic
{
    public class HistoryItem
    {
        //gets and sets the URL, title, Id, and date for history
        public String URL { get; set; }
        public String Title { get; set; }
        public String Date { get; set; }
        public int Id { get; set; }
    }
}
