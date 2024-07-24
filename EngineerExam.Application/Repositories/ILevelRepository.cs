using EngineerExam.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineerExam.Application.Repositories
{
    public interface ILevelRepository : IBaseRepository<Level>
    {
       public Task<Level> GetById(Guid id, CancellationToken cancellationToken);
       public Task<List<Level>> GetByTitle(string title, CancellationToken cancellationToken);
    }
}
