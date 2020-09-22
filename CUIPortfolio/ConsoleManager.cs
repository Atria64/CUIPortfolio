using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CUIPortfolio
{
    public class ConsoleManager
    {
        //イベントハンドラ後でしっかり作る
        public static event EventHandler ListChanged;
        public static IReadOnlyList<string> Inputs { get; private set; } = new List<string> {};

        /// <summary>
        /// 要素を追加し、新しく領域を確保します
        /// </summary>
        /// <param name="Input">追加する要素</param>
        static public void AddElement(string Input)
        {
            var ls = Inputs.ToList();
            if(ls.Count > 1)ls.RemoveAt(ls.Count - 1);//OutOfIndex対策
            ls.Add(Input);
            ls.Add("");
            Inputs = ls;
            ListChanged(null, EventArgs.Empty);
        }

        static public void Clear()
        {
            Inputs = new List<string> {};
            ListChanged(null, EventArgs.Empty);
        }
    }
}
