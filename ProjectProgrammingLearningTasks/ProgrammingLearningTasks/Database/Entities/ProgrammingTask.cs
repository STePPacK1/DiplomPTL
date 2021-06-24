using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProgrammingLearningTasks.Database.Entities
{
    public class ProgrammingTask
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }
        
        public ICollection<Image> Images { get; set; }
        
        public string Text { get; set; }
        
        public ICollection<NestedFile> NestedFiles { get; set; }
        
        public DateTime CreationDate { get; set; } = DateTime.Now;
        
        public string Comment { get; set; }
        
        public string InputDataText { get; set; }
        
        public string OutputDataText { get; set; }

        public ICollection<TestValue> TestValues { get; set; }
        
        public Topic Topic { get; set; }
        
        public int Complexity { get; set; }

        public User Author { get; set; }

        public ICollection<Solution> Solutions { get; set; }
    }
}