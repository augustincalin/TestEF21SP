using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        [HttpGet]
        [Route("/api/[controller]/{classId}")]
        public async Task<IActionResult> GetStudentsByClass(int classId)
        {
            return new OkObjectResult(await _studentService.GetStudentsByClassAsync(classId));
        }
    }
}
