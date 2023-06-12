using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Einheit13.InheritanceExample.Model
{
    public class Medium
    {
        protected int size;

        public Medium(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public void Print()
        {
            var a = $"{size} und {Name}";
        }
    }
}
