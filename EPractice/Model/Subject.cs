using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPractice.Model
{
    public class Subject
    {
        public List<Chapter> chapter = new List<Chapter>();
        public string Name { get; set; }

        
    }
}
