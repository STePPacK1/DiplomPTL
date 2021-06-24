using System.Collections.Generic;

namespace ProgrammingLearningTasks.Models.ProgrammingTasks
{
    public class EditTaskViewModel
    {
        public int Id { get; set; }

        public string TopicName { get; set; }

        public string Name { get; set; }

        public string Text { get; set; }

        public string Comment { get; set; }

        public string InputDataText { get; set; }

        public string OutputDataText { get; set; }

        public TestValueViewModel[] TestValues { get; set; } 

        public int Complexity { get; set; }

        public int[] ImageIds { get; set; } = new int[] { };

        public NestedFileViewModel[] NestedFiles { get; set; } = new NestedFileViewModel[] { };
    }
}