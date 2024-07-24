using EngineerExam.Application.Repositories;
using EngineerExam.Domain.Models;
using EngineerExam.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineerExam.Persistance.Repositories.Impelementations
{
    public class LevelRepository : BaseRepository<Level>, ILevelRepository
    {
        public LevelRepository(EngineerExamContext context) : base(context)
        {
        }

        public async Task<Level> GetById(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

     
        public async Task<List<Level>> GetByTitle(string title, CancellationToken cancellationToken)
        {
            return await Context.Levels.Where(x => x.Title == title).ToListAsync();
        }
    }
}
