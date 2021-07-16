using DapperTest.Define;
using DapperTest.Model;

namespace DapperTest.Service
{
    public class DapperService: IService
    {
        private readonly IUserRepository _userRepository;

        public DapperService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public object DeleteDB(int id)
        {
            return _userRepository.Delete(id);
        }

        public object GetDB()
        {
            return _userRepository.Get();
        }

        public object GetDB(int id)
        {
            return _userRepository.Get(id);
        }

        public object PostDB(UserModel model)
        {
            return _userRepository.Post(model);
        }

        public object PutDB(UserModel model)
        {
            return _userRepository.Put(model);
        }
    }
}
