using Fishy_Projek.Models;
using Fishy_Projek.Repositories;

namespace Fishy_Projek.Controllers
{
    public class AuthController
    {
        private OperasionalRepository _opsRepo = new OperasionalRepository();

        public User ValidasiLogin(string username, string password)
        {
            return _opsRepo.Login(username, password);
        }
    }
}