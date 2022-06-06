using ProfileBook1804.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;


namespace ProfileBook1804.Services.Repositorys
{
    public class Repository : IRepository
    {

        private Lazy<SQLiteAsyncConnection> _database;

        public Repository ()
        {
             

             _database = new Lazy<SQLiteAsyncConnection>(() =>
            {
                var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "_profileBook.db3");
                var database = new SQLiteAsyncConnection(path);

                database.CreateTableAsync<ContactModel>();
                database.CreateTableAsync<UserModel>();

                return database;
            });
        }
        
        public async Task<List<T>> GetAllAsync<T>() where T : IEntityBase, new()
        {
            return await _database.Value.Table<T>().ToListAsync();
        }

        public async Task<int> InsertAsync<T>(T entity) where T : IEntityBase, new()
        {
            return await _database.Value.InsertAsync(entity);
        }

        public async Task<int> DeleteAsync<T>(T entity) where T : IEntityBase, new()
        {
            return await _database.Value.DeleteAllAsync<T>();
        }

        public async Task<int> UpdateAsync<T>(T entity) where T : IEntityBase, new()
        {
           return await _database.Value.UpdateAsync(entity);
        }
    }
}
