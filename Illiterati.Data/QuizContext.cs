using Illiterati.Quiz.Entities;
using Microsoft.EntityFrameworkCore;

namespace Illiterati.Data;
public class QuizContext : DbContext
{
    public QuizContext() : base()
    {
    }

    public DbSet<Work> Works { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Genre> Genres { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder opt)
    {
        opt.UseSqlite("Data Source=Submissions.db");
    }
}
