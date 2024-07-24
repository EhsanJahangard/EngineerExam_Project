using EngineerExam.Application.Repositories;
using EngineerExam.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineerExam.Persistance.Repositories.Impelementations;
public class UnitOfWork : IUnitOfWork
{
    private readonly EngineerExamContext _context;

    public UnitOfWork(EngineerExamContext context)
    {
        _context = context;
    }
    public Task Save(CancellationToken cancellationToken)
    {
        return _context.SaveChangesAsync(cancellationToken);
    }
}