using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Einheit13.InheritanceExample.Model
{
    public class Cd : Medium
    {
        public Cd(string name) : base(name)
        {
        }

        public int CdSize()
        {
            var s = 2 + size;
            return s;
        }

        public string Interpreter { get; set; }
    
        //public void Print()
        //{
        //    // hier was machen
        //    base.Print();
        //    //rest impl.
        //}
    }
}
