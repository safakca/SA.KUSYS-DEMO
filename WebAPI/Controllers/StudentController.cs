using AutoMapper;
using Business.Abstract;
using DataAccess.Dtos;
using DataAccess.Entites;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;

        public StudentController(IStudentService studentService, IMapper mapper)
        {
            _studentService = studentService;
            _mapper = mapper;
        }

        [HttpPost("add")]
        public IActionResult Create(CreateStudentDto model)
        {
            var student = _mapper.Map<Student>(model);
            var createdStudent = _studentService.Create(student);
            var createdStudentDto = _mapper.Map<CreateStudentDto>(createdStudent);
            return Created("", createdStudentDto);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var students = _studentService.GetAllStudentByCourse();
            var mappedStudent = _mapper.Map<List<GetStudentDto>>(students);
            return Ok(mappedStudent);
        }

        [HttpGet("getbyid")]
        public IActionResult GetStudentByCourse(int id)
        {
            var students = _studentService.GetStudentByCourse(id);
            var mappedStudent = _mapper.Map<GetStudentDto>(students);
            return Ok(mappedStudent);
        }

        [HttpPut("update")]
        public IActionResult Update(UpdateStudentDto model)
        {
            var student = _mapper.Map<Student>(model);
            var updatedStudent=_studentService.Update(student);
            var mappedStudentDto = _mapper.Map<UpdateStudentDto>(updatedStudent);
            return Ok(mappedStudentDto);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(int id)
        {
            var deleted= _studentService.Delete(id);
            return Ok(deleted);
        }
    }
}
