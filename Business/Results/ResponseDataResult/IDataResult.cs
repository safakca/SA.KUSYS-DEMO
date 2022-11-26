namespace Business.Results;
public interface IDataResult<T> 
{
    bool Success { get; }
    string Message { get; }
    T Data { get; }
}
