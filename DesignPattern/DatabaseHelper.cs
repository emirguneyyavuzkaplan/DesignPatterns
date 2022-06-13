using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class DatabaseHelper
    {
        private static DatabaseHelper _databaseHelper;
        private DatabaseHelper()
        {
            System.Console.WriteLine("Database create edildi...");
        }

        private static DateTime OlusmaZamani;
        public static DatabaseHelper GetDatabaseHelper()
        {
            if (_databaseHelper == null)
            {
                _databaseHelper = new DatabaseHelper();
                OlusmaZamani = DateTime.Now;
                System.Console.WriteLine("Zaman"+OlusmaZamani);
                return _databaseHelper;
            }
            else
            {
                System.Console.WriteLine("Zaman" +OlusmaZamani);
                return _databaseHelper;
            }
        }
    }
}