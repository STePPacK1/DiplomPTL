namespace ProgrammingLearningTasks.Models.ProgrammingTasks
{
    public class UpdateSolutionViewModel
    {
        public int Id { get; set; }
        
        public int TaskId { get; set; }
        
        public string Text { get; set; }

        public string Code { get; set; }
        
        public string LangName { get; set; }
    }
}