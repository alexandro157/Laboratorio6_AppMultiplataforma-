using System;
using System.Collections.Generic;
using System.Text;

namespace ListViewExample
{
    public class Uni : List<Alumn>
    {
        public string Name { get; set; }
        public Uni(string name)
        {
            Name = name;
        }    
    }
}
