using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProgrammingLearningTasks.Database.Entities
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string FullName { get; set; }

        public string Position { get; set; }
        
        public string Login { get; set; }

        public string Password { get; set; }
    }
}