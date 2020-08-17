using System.Collections.Generic;

namespace CUIPortfolio
{
    public class Work
    {

        public Work(string name, List<string> language, string description, string command)
        {
            Name = name;
            Language = language;
            Description = description;
            Command = command;
        }

        public string Name { get; private set; }
        public List<string> Language { get; private set; }
        public string Description { get; private set; }
        public string Command { get; private set; }
    }
}
