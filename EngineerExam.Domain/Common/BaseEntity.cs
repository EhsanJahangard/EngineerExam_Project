namespace EngineerExam.Domain.Common;
//baseEntity
public class BaseEntity<T>
{
    public BaseEntity() { }
    public T Id { get; set; }
    public DateTime DateCreate { get; set; }
    public string UserCreate { get; set; }
    public DateTime DateUpdate { get; set; }
    public string UserUpdate { get; set; }
}
