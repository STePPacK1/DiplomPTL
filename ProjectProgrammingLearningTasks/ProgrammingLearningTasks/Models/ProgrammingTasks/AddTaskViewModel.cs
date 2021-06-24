using Microsoft.AspNetCore.Http;

namespace ProgrammingLearningTasks.Models.ProgrammingTasks
{
    public class AddTaskViewModel
    {
        public string TopicName { get; set; }

        public string Name { get; set; }
        
        public string Text { get; set; }
        
        public string Comment { get; set; }

        public string InputDataText { get; set; }

        public string OutputDataText { get; set; }

        public TestValueViewModel[] TestValues { get; set; }
        
        public int Complexity { get; set; }
    }
}