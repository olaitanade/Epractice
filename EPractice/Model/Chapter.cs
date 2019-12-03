using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPractice.Model
{
    public class Chapter
    {
        public string Name { get; set; }
        public List<string> pages;

        public Chapter(string n, List<string> c)
        {
            Name = n;
            pages = c;
        }
    }
}
