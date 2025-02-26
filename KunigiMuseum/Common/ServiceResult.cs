namespace KunigiMuseum.Common;

public class ServiceResult<T>
{
    public bool IsSuccess { get; }
    public List<ErrorDetail> Errors { get; } = new List<ErrorDetail>();
    public T Value { get; }

    private ServiceResult(bool isSuccess, T value)
    {
        IsSuccess = isSuccess;
        Value = value;
    }

    public static ServiceResult<T> Success(T value) =>
        new ServiceResult<T>(true, value);

    public static ServiceResult<T> Failure(string error) =>
        Failure(new ErrorDetail { Message = error });

    public static ServiceResult<T> Failure(string fieldName, string error) =>
        Failure(new ErrorDetail { FieldName = fieldName, Message = error });

    public static ServiceResult<T> Failure(ErrorDetail error)
    {
        var result = new ServiceResult<T>(false, default);
        result.Errors.Add(error);
        return result;
    }

    public static ServiceResult<T> Failure(IEnumerable<ErrorDetail> errors)
    {
        var result = new ServiceResult<T>(false, default);
        result.Errors.AddRange(errors);
        return result;
    }

    public bool HasErrors => Errors.Any();
}

public class ErrorDetail
{
    public string FieldName { get; set; }
    public string Message { get; set; }
}