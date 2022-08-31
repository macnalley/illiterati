using Illiterati.Quiz.Entities;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var works = DeserializeSeedData();

        foreach (var work in works)
        {
            modelBuilder.Entity<Work>().HasData(work);
        }
    }

    private List<Work> DeserializeSeedData()
    {
        var works = new List<Work>();
        
        string seedDataFilePath = Environment.CurrentDirectory + @"\SeedData\Works.json";

        using (var streamReader = new StreamReader(seedDataFilePath))
        {
            string jsonData = streamReader.ReadToEnd();

            works = JsonSerializer.Deserialize<List<Work>>(jsonData);
        }

        return works;
    }
}
