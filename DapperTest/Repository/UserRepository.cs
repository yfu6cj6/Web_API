using Dapper;
using DapperTest.Define;
using DapperTest.Model;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DapperTest.Repository
{
    public class UserRepository: IUserRepository
    {
        private readonly string _sql = "server =127.0.0.1; port = 3306; uid = root; pwd = 123456; database = 'Test'; ";

        public async Task<IEnumerable<dynamic>> Get()
        {
            using var conn = new MySqlConnection(_sql);
            return await conn.QueryAsync("SELECT * FROM `User`");
        }

        public async Task<IEnumerable<dynamic>> Get(int id)
        {
            using var conn = new MySqlConnection(_sql);
            return await conn.QueryAsync("SELECT * FROM `User` WHERE `id` = @id", new { id });
        }

        public async Task<int> Post(UserModel model)
        {
            using var conn = new MySqlConnection(_sql);
            return await conn.ExecuteAsync("INSERT INTO `User` (`Account`, `Password`	) VALUES (@account, @password)", model);
        }

        public async Task<int> Put(UserModel model)
        {
            using var conn = new MySqlConnection(_sql);
            return await conn.ExecuteAsync("UPDATE `User` SET `Account` = @Account, `Password` = @Password WHERE id = @id", model);
        }

        public async Task<int> Delete(int id)
        {
            using var conn = new MySqlConnection(_sql);
            return await conn.ExecuteAsync("DELETE FROM `User` WHERE `id` = @id", new { id });
        }
    }
}
