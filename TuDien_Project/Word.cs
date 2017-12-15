using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuDien_Project
{
    public class Word
    {
        public string Eng { get; set; }
        public string Viet { get; set; }

        public Word(string name, string meaning)
        {
            this.Eng = name;
            this.Viet = meaning;
        }

        public Word()
        {
            
        }
    }
}
