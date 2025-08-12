using healthcareProject.Models.Entity;
using Microsoft.EntityFrameworkCore;
namespace healthcareProject.Repositorys
{
    public class ClassRepository
    {
        private readonly HealthcareProjectContext _context;
        public ClassRepository(HealthcareProjectContext context)
        {
            _context = context;
        }

        public async Task<List<Class>> GetAllClasses()
        {
            return await _context.Classes.ToListAsync();
        }

        public async Task<Class> GetClassByClassId(int classId)
        {
            return await _context.Classes.FindAsync(classId);
        }
    }
}