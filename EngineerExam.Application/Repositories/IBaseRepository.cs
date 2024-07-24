using EngineerExam.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineerExam.Application.Repositories;

public interface IBaseRepository<T>
{
    void Create(T entity);
    void Update(T entity);
    void Delete(T entity);
    Task<T> Get(Guid id, CancellationToken cancellationToken);
    Task<List<T>> GetAll(CancellationToken cancellationToken);
}
