namespace ProgrammingLearningTasks.Models.ProgrammingTasks
{
    public class TopicTreeJsViewNode
    {
        public string Id { get; set; }

        public string Parent { get; set; }

        public string Text { get; set; }

        public A_attr A_attr { get; set; }


        public TreeViewState State { get; set; } = new TreeViewState();
    }

    public class A_attr
    {
        public A_attr(string href)
        {
            Href = href;
        }

        public string Href { get; }
    }
}