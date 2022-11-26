using AutoMapper;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Dtos;
using DataAccess.Entites;
using System.Linq.Expressions;

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

    public CreateStudentDto Create(CreateStudentDto entity)
    {
        var student = _mapper.Map<Student>(entity);
        var create = _studentDal.Create(student);
        var mapped = _mapper.Map<CreateStudentDto>(create);
        return mapped;
    }

    public bool Delete(int id)
    {
        _studentDal.Delete(id);
        return true;
    }

    public List<GetStudentDto> GetAllStudentByCourse()
    {
       var students = _studentDal.GetAllStudentByCourse();
       var mapped = _mapper.Map<List<GetStudentDto>>(students);
        return mapped;
    }

    public GetStudentDto GetStudentByCourse(int id)
    {
        var student = _studentDal.GetStudentByCourse(id);
        var mapped = _mapper.Map<GetStudentDto>(student);
        return mapped;
    }

    public UpdateStudentDto Update(UpdateStudentDto model)
    {
        var student = _mapper.Map<Student>(model);
        var update = _studentDal.Update(student);
        var mapped = _mapper.Map<UpdateStudentDto>(update);
        return mapped;
    }
}
