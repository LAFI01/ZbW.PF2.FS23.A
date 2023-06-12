﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Einheit13.InheritanceExample.Model
{
    public class Dvd : Medium
    {
        public Dvd(string n) : base(n)
        {

        }

        public string Actor { get; set; } 
    }
}
