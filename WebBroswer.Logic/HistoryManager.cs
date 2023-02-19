using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebBrowser.Data.HistoryDataSetTableAdapters;

namespace WebBroswer.Logic
{
    public class HistoryManager
    {
        //Add item keeps throwing a unhandled exception error, so inserted a try catch
        public static void AddItem(HistoryItem itemAdd)
        {
            var adapter = new HistoryTableAdapter();
            try
            {
                adapter.Insert(itemAdd.URL, itemAdd.Title, itemAdd.Date);
            }
            catch (Exception ex)
            {
             Console.WriteLine(ex.ToString());
            }
           

        }

        public static void RemoveItem(HistoryItem deleteItem)
        {
            //create new history table object
            var adapter = new HistoryTableAdapter();
            //Delete history item from table adapter
            adapter.Delete(deleteItem.Id, deleteItem.URL, deleteItem.Title, deleteItem.Date);
        }

      
        public static List<HistoryItem> GetItems()
        {
            var adapter = new HistoryTableAdapter();
            var results = new List<HistoryItem>();
            var rows = adapter.GetData();

            foreach ( var row in rows )
            {
                var item = new HistoryItem();
                item.URL = row.URL;
                item.Title = row.Title_;
                item.Date = row.Date;
                item.Id = row.Id;

                results.Add(item);
            }
            return results;
        }

        public static void ClearHistory()
        {
            var clearhistory = HistoryManager.GetItems();
            foreach ( var item in clearhistory )
            {
                RemoveItem(item);
            }

        }
    }
}
