using System.Linq;

namespace ProgrammingLearningTasks.Utils
{
    public static class StringExtensions
    {
        public static string FirstCharToLower(this string input) =>
            input switch
            {
                null => null,
                "" => null,
                _ => input.First().ToString().ToLower() + input.Substring(1)
            };
    }
}