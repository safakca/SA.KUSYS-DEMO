using Business.Results;
using DataAccess.Dtos;

namespace Business.Abstract;

public interface IStudentService
{
    IDataResult<List<GetStudentDto>> GetAllStudentByCourse();
    IDataResult<GetStudentDto> GetStudentByCourse(int id);
    IDataResult<CreateStudentDto> Create(CreateStudentDto model);
    IResult Delete(int id);
    IDataResult<UpdateStudentDto> Update(UpdateStudentDto model);
}
