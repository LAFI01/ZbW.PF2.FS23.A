using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Einheit13.InheritanceExample.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Ucd : Cd
    {
        public Ucd(string name) : base(name)
        {
        }

        /// <summary>
        /// sdfdsfsdfsd
        /// </summary>
        /// <param name="name">The name</param>
        public void Print()
        {
            base.Print();
            var b = 12;
        }
    }
}
