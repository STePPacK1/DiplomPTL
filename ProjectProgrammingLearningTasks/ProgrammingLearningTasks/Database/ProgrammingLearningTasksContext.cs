using System.Linq;
using Microsoft.EntityFrameworkCore;
using ProgrammingLearningTasks.Database.Entities;

namespace ProgrammingLearningTasks.Database
{
    public sealed class ProgrammingLearningTasksContext : DbContext
    {
        public DbSet<Image> Images { get; set; }

        public DbSet<NestedFile> NestedFiles { get; set; }

        public DbSet<ProgrammingLanguage> ProgrammingLanguages { get; set; }

        public DbSet<ProgrammingTask> ProgrammingTasks { get; set; }

        public DbSet<Solution> Solutions { get; set; }

        public DbSet<TestValue> TestValues { get; set; }

        public DbSet<Topic> Topics { get; set; }

        public DbSet<User> Users { get; set; }

        public ProgrammingLearningTasksContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=ProgrammingLearningTasks;Integrated Security=true");
        }

        public static void Seed(ProgrammingLearningTasksContext context, User defaultUser)
        {
            if (!context.Users.Any())
            {
                context.Users.Add(defaultUser);
                context.SaveChanges();
            }
        }
    }
}