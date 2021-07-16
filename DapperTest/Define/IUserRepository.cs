using DapperTest.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DapperTest.Define
{
    public interface IUserRepository
    {
        public Task<IEnumerable<dynamic>> Get();

        public Task<IEnumerable<dynamic>> Get(int id);

        public Task<int> Post(UserModel model);

        public Task<int> Put(UserModel model);

        public Task<int> Delete(int id);
    }
}
