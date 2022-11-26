using AutoMapper;
using Business.Abstract;
using Business.Constants;
using Business.Results;
using DataAccess.Abstract;
using DataAccess.Dtos;
using DataAccess.Entites;

namespace Business.Concrete;

public class StudentManager : IStudentService
{
    private readonly IStudentDal _studentDal;
    private readonly IMapper _mapper;
    public StudentManager(IStudentDal studentDal, IMapper mapper)
    {
        _studentDal = studentDal;
        _mapper = mapper;
    }

    public IDataResult<CreateStudentDto> Create(CreateStudentDto entity)
    {
        var student = _mapper.Map<Student>(entity);
        var create = _studentDal.Create(student);
        var mapped = _mapper.Map<CreateStudentDto>(create);
        return new SuccessDataResult<CreateStudentDto>(mapped, Messages.SuccesedCreate);
    }

    public IResult Delete(int id)
    {
        _studentDal.Delete(id);
        return new SuccessResult(Messages.SuccesedDelete);
    }

    public IDataResult<List<GetStudentDto>> GetAllStudentByCourse()
    {
        var students = _studentDal.GetAllStudentByCourse();
        var mapped = _mapper.Map<List<GetStudentDto>>(students);
        return mapped != null
           ? new SuccessDataResult<List<GetStudentDto>>(mapped, Messages.SuccesedList)
           : new ErrorDataResult<List<GetStudentDto>>(mapped, Messages.NotExistRecord);
    }

    public IDataResult<GetStudentDto> GetStudentByCourse(int id)
    {
        var student = _studentDal.GetStudentByCourse(id);
        var mapped = _mapper.Map<GetStudentDto>(student);
        return mapped != null
            ? new SuccessDataResult<GetStudentDto>(mapped, Messages.SuccesedList)
            : new ErrorDataResult<GetStudentDto>(mapped, Messages.NotExistRecord);
    }

    public IDataResult<UpdateStudentDto> Update(UpdateStudentDto model)
    {
        var student = _mapper.Map<Student>(model);
        var update = _studentDal.Update(student);
        var mapped = _mapper.Map<UpdateStudentDto>(update);
        return new SuccessDataResult<UpdateStudentDto>(mapped, Messages.SuccesedUpdate);
    }
}
