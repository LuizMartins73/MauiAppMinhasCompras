using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppMinhasCompras.Helpers
{
    public class SQLiteDataBaseHelper
    {
        readonly SQLiteAsyncConnection _conn;

        public SQLiteDataBaseHelper(string path)
        {
         _conn = new SQLiteAsyncConnection(path);
         _conn.CreateTableAsync<Produto>().Wait();
        }
    }
}
