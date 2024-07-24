using EngineerExam.Application.Repositories;
using EngineerExam.Domain.Common;
using EngineerExam.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineerExam.Persistance.Repositories.Impelementations;
public class BaseRepository<T> : IBaseRepository<T> where T : Domain.Common.BaseEntity<Guid>
{
    protected readonly EngineerExamContext Context;

    public BaseRepository(EngineerExamContext context)
    {
        Context = context;
    }

    public void Create(T entity)
    {
        Context.Add(entity);
    }

    public void Update(T entity)
    {
        Context.Update(entity);
    }

    public void Delete(T entity)
    {
        entity.DateCreate = DateTime.UtcNow;
        Context.Update(entity);
    }

    public async Task<T> Get(Guid id, CancellationToken cancellationToken)
    {
        return await Context.Set<T>().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
    }

    public Task<List<T>> GetAll(CancellationToken cancellationToken)
    {
        return Context.Set<T>().ToListAsync(cancellationToken);
    }
}