using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using ProgrammingLearningTasks.Database.Entities;

namespace ProgrammingLearningTasks.Models.ProgrammingTasks
{
    public class TopicTreeContainer
    {
        public TopicTreeJsViewNode[] TopicTreeJsViewNodes { get; private set; } = { };
        
        public void FillTopicJsView(Topic[] topics)
        {
            var testTreeViewNodes = new List<TopicTreeJsViewNode>();
            foreach (var topic in topics)
            {
                testTreeViewNodes.Add(new TopicTreeJsViewNode()
                {
                    Id = topic.Id.ToString(),
                    A_attr = new A_attr($"/ProgrammingTasks/TopicTasks/{topic.Id}"),
                    Parent = topic.ParentId.HasValue 
                        ? topic.ParentId.ToString()
                        : "#",
                    
                    Text = topic.Name
                });
            }

            TopicTreeJsViewNodes = testTreeViewNodes.ToArray();
        }
    }
}