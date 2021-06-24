using Microsoft.EntityFrameworkCore.Metadata;

namespace ProgrammingLearningTasks.Models.ProgrammingTasks
{
    public class SolutionViewModel
    {
        public int Id { get; set; }
        
        public string Text { get; set; }

        public string Code { get; set; }
        
        public string LangName { get; set; }
    }
}