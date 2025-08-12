using healthcareProject.Models.Entity;
using healthcareProject.Repositorys;

namespace healthcareProject.Services
{
    public class UserService
    {
        private readonly UserRepository _userRepository;
        public UserService()
        {
            _userRepository = new UserRepository();
        }

        public async Task<User?> Login(string email, string password)
        {
            return await _userRepository.Login(email, password);
        }
    }
}
