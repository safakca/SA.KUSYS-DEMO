using DataAccess.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Dtos;

public class CreateStudentDto
{
    public int CourseId { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string BirthDate { get; set; } 
}
