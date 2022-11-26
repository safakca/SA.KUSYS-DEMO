using Business.Abstract;
using DataAccess.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService; 
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        /// <summary>
        /// add student
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("add")]
        public IActionResult Create(CreateStudentDto model) => Created("", _studentService.Create(model));

        /// <summary>
        /// get all student with course
        /// </summary>
        /// <returns></returns>
        [HttpGet("getall")]
        public IActionResult GetAll()=> Ok(_studentService.GetAllStudentByCourse());    

        /// <summary>
        /// getById student with course
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("getbyid")]
        public IActionResult GetStudentByCourse(int id) => Ok(_studentService.GetStudentByCourse(id));

        /// <summary>
        /// update student
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPut("update")]
        public IActionResult Update(UpdateStudentDto model) => Ok(_studentService.Update(model));

        /// <summary>
        /// delete student
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("delete")]
        public IActionResult Delete(int id) => Ok(_studentService.Delete(id));
    }
}
