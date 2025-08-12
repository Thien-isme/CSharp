using healthcareProject.Models.Entity;
using healthcareProject.Repositorys;

namespace healthcareProject.Services
{
    public class ClassService
    {
        private readonly ClassRepository classRepository;

        public ClassService(ClassRepository classRepository)
        {
            this.classRepository = classRepository;
        }

        public async Task<List<Class>> GetAllClasses()
        {
            return await classRepository.GetAllClasses();
        }

        public async Task<Class> GetClassByClassId(int classId)
        {
            return await classRepository.GetClassByClassId(classId);
        }
    }
}