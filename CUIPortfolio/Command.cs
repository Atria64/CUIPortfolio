using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CUIPortfolio
{
    public class Command
    {
        public Command(string name, string discription)
        {
            Name = name;
            Discription = discription;
        }

        //コマンド名
        public string Name { get; set; }
        //コマンドの動作内容
        public string Discription { get; set; }
    }
}
