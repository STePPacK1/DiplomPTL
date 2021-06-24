using System;

namespace ProgrammingLearningTasks.Models.ProgrammingTasks
{
    public class TopicTasksModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Author { get; set; }
        
        public string CreationDate { get; set; }
        
        public int Complexity { get; set; }
    }
}