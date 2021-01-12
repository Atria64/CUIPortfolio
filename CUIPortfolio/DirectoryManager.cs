using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CUIPortfolio
{
    public class DirectoryManager
    {
        Directory directory;
        public DirectoryManager()
        {
            directory = new Directory("atria");
            directory.Commands.Add(new Command("bio","自己紹介を表示します"));
            directory.Children.Add(new Directory("about"));
            directory.Children.Add(new Directory("works"));
        }
    }
}
