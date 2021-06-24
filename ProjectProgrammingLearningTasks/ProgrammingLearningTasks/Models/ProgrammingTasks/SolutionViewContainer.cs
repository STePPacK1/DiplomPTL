using System.Collections.Generic;

namespace ProgrammingLearningTasks.Models.ProgrammingTasks
{
    public class SolutionViewContainer
    {
        public string TaskName { get; set; }

        public int TaskId { get; set; }

        public List<SolutionViewModel> SolutionViewModels { get; set; }
    }
}