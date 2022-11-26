using AutoMapper;
using DataAccess.Dtos;
using DataAccess.Entites;

namespace DataAccess.Mapping; 
public class StudentProfile : Profile
{
    public StudentProfile()
    {
        CreateMap<Student, CreateStudentDto>().ReverseMap();
        CreateMap<GetStudentDto, Student>().ReverseMap();
        CreateMap<Student, UpdateStudentDto>().ReverseMap();
    }
}
