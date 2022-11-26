using AutoMapper;
using DataAccess.Dtos;
using DataAccess.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
