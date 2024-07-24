using EngineerExam.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EngineerExam.Persistance.Configs;

public class LevelConfig : IEntityTypeConfiguration<Level>
{
    public void Configure(EntityTypeBuilder<Level> builder)
    {
        builder.Property(r => r.Id)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("NEWID()");

    }
}
