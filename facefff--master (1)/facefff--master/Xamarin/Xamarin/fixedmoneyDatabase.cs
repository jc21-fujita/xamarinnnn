using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Threading.Tasks;



namespace Xamarin
{
    public class fixedmoneyDatabase
    {
        readonly SQLiteAsyncConnection database;

        public fixedmoneyDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<fixedmoney>().Wait();
        }

        public Task<List<fixedmoney>> GetItemsAsync()
        {
            return database.Table<fixedmoney>().ToListAsync();
        }

        public Task<List<fixedmoney>> GetItemsNotDoneAsync()
        {
            return database.QueryAsync<fixedmoney>("SELECT * FROM [fixedmoney] WHERE [Done] = 0");
        }

        public Task<fixedmoney> GetItemAsync(int id)
        {
            return database.Table<fixedmoney>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<List<fixedmoney>> GetItemDay(System.Collections.Generic.List<System.DateTime> day)
        {
            var DayList = day;
            DateTime Daykd = day[0];
            return database.QueryAsync<fixedmoney>("SELECT * FROM [fixedmoney] WHERE Day = " + Daykd);
        }


        public Task<int> SaveItemAsync(fixedmoney item)
        {
            if (item.ID != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync(fixedmoney item)
        {
            return database.DeleteAsync(item);

        }
    }
}
