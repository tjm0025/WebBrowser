using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBrowser.Data.BookmarkDataSetTableAdapters;

namespace WebBroswer.Logic
{
    public class BookmarkManager
    {
        //Add item keeps throwing a unhandled exception error, so inserted a try catch
        public static void AddItem(BookmarkItem itemAdd)
        {
            var adapter = new BookmarkTableAdapter();
            try
            {
                adapter.Insert(itemAdd.URL, itemAdd.Title);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        //Deletes bookmark item from bookmark database
        public static void RemoveBookmark(BookmarkItem removeItem)
        {
            var adapter = new BookmarkTableAdapter();
            adapter.Delete(removeItem.Id, removeItem.URL, removeItem.Title);
        }

        public static List<BookmarkItem> GetItems()
        {
            var adapter = new BookmarkTableAdapter();
            var results = new List<BookmarkItem>();
            var rows = adapter.GetData();

            foreach ( var row in rows )
            {
                var item = new BookmarkItem();
                item.Title = row.Title;
                item.URL = row.URL;
                item.Id = row.Id;

                results.Add(item);
            }
            return results;
        }


    }
}
