using DapperTest.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DapperTest.Define
{
    public interface IService
    {
        public object DeleteDB(int id);

        public object GetDB();

        public object GetDB(int id);

        public object PostDB(UserModel model);

        public object PutDB(UserModel model);
    }
}
