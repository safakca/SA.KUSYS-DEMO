using Business.Repositories;
using DataAccess.Dtos;
using DataAccess.Entites;
using System.Linq.Expressions;

namespace Business.Abstract;

public interface IStudentService 
{
    List<GetStudentDto> GetAllStudentByCourse();
    GetStudentDto GetStudentByCourse(int id);
    CreateStudentDto Create(CreateStudentDto model);
    bool Delete(int id);
    UpdateStudentDto Update(UpdateStudentDto model);
}
