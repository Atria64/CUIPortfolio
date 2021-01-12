using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CUIPortfolio
{
    public class Directory
    {
        public Directory(string directoryName)
        {
            DirectoryName = directoryName;
            Children = new List<Directory>();
            Commands = new List<Command>();
        }

        public string DirectoryName { get; set; }
        public List<Directory> Children { get; set; }
        public List<Command> Commands { get; set; }
    }
}
