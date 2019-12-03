using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPractice.Model
{
    public sealed class Singleton
    {
        private static Singleton instance = null;
        public List<Subject> subjects = new List<Subject>();
        public int SelectedIndex { get; set; }
        public int selectedChapIndex { get; set; }
        public bool alreadySet = false;

        private Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
    }
}
