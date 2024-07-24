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
        Task<Level> GetByEmail(string email, CancellationToken cancellationToken);
    }
}
