using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CUIPortfolio
{
    public class Command
    {
        public Command(string name, string explanation)
        {
            Name = name;
            Explanation = explanation;
        }

        //コマンド名
        public string Name { get; private set; }
        //コマンドの動作内容
        public string Explanation { get; private set; }
    }
}
