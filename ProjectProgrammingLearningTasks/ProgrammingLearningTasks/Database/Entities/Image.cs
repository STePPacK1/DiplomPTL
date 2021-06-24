using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProgrammingLearningTasks.Database.Entities
{
    public class Image
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public byte[] Content { get; set; }

        public string FileName { get; set; }
        
        public string Extension { get; set; }
    }
}