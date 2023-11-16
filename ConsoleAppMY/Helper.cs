using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMY
{
    public class Helper
    {
        public String Ellipsis(String input, int len)
        {
            //return input.Substring(0, len - 3) + "..."; 
            //return len == 5 ? "He..." : "Hel...";
            return $"Hel"[..(len - 3)]+"...";
        }
    }
}
