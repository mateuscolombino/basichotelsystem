﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp42
{
    internal class HostelSystem
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Room { get; set; }

        
        public override string ToString()
        {
            return $"{Room}: {Name}, {Email}";
        }







    }
}
