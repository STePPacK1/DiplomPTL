using System.Linq;
using Newtonsoft.Json.Serialization;
using ProgrammingLearningTasks.Utils;

namespace ProgrammingLearningTasks.Configurations
{
    public class LowercaseContractResolver : DefaultContractResolver
    {
        protected override string ResolvePropertyName(string propertyName)
        {
            return propertyName.FirstCharToLower();
        }
    }
}