using System.Collections.Generic;
using System.Linq;

namespace Einheit11.Color
{
    internal static class Color
    {
        public static string Name { get; set; }

        public static void LinqNameSpace()
        {
            var a = new List<string>();
            var klasseListe = new List();
            //Entferne oben "using System.Linq"
            //und a kennt die Methode "Where" nicht mehr
            var c = a.Where(a => a != null);
        }
    }
}
