namespace ProgrammingLearningTasks.Models.ProgrammingTasks
{
    public class TaskReportViewModel
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public string Text { get; set; }

        public NestedFileReportViewModel[] NestedFiles { get; set; }

        public string CreationDate { get; set; }

        public string Comment { get; set; }

        public TestValueViewModel[] TestValues { get; set; }

        public string TopicName { get; set; }

        public int Complexity { get; set; }

        public string Author { get; set; }

        public string InputDataText { get; set; }

        public string OutputDataText { get; set; }
    }
}