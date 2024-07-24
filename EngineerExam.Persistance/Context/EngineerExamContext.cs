using EngineerExam.Domain.Models;
using Microsoft.EntityFrameworkCore;
namespace EngineerExam.Persistance.Context;

public class EngineerExamContext : DbContext
{
    public EngineerExamContext(DbContextOptions<EngineerExamContext> options) : base(options)
    {
    }

    public DbSet<Level> Levels { get; set; }
}
