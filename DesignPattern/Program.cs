using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {

            //DatabaseHelper dbHelper = new DatabaseHelper();
            //DatabaseHelper dbHelper2 = new DatabaseHelper();
            //DatabaseHelper dbHelper3 = new DatabaseHelper();
            var dbHelper = DatabaseHelper.GetDatabaseHelper();
            Task.Delay(3000);
            var dbHelper2 = DatabaseHelper.GetDatabaseHelper();
            Task.Delay(3000);
            var dbHelper3 = DatabaseHelper.GetDatabaseHelper();
            var log = logger.Logger;
        }
    }
}
