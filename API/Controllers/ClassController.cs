using healthcareProject.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace healthcareProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize] // Thêm dòng này để yêu cầu xác thực JWT
    public class ClassController : ControllerBase
    {
        private readonly ClassService classService;

        public ClassController(ClassService classService)
        {
            this.classService = classService;
        }

        [HttpGet("GetAllClasses")]
        public async Task<IActionResult> GetAllClasses()
        {
            var classes = await classService.GetAllClasses();
            return Ok(classes);
        }

        [HttpGet("GetClassByClassId/{classId}")]
        public async Task<IActionResult> GetClassById(int classId)
        {
            var classObj = await classService.GetClassByClassId(classId);
            if (classObj == null)
            {
                return NotFound("Không có class trong hệ thống");
            }
            return Ok(classObj);
        }
    }
}
