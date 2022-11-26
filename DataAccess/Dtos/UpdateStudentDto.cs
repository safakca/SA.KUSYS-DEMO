using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Dtos;

public class UpdateStudentDto
{
    public int Id { get; set; }
    public int CourseId { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string BirthDate { get; set; } 
}
