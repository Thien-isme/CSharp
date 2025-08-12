using healthcareProject.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace healthcareProject.Repositorys
{
    public class UserRepository
    {
        private readonly HealthcareProjectContext _context;
        public UserRepository()
        {
            _context = new HealthcareProjectContext();
        }

        public async Task<User?> Login(string email, string password)
{
        return await _context.Users
        .FirstOrDefaultAsync(u => u.Email == email && u.Password == password && u.Active == true);
}
    }
}
