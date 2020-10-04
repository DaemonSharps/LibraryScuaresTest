using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryAreas.Interfaces;

namespace LibraryAreas.Classes
{
    class circle:Area,Shapes
    {public int RadiusCount { get; set; }
        public circle() 
        { }
        public double Area { get; set; }
        public double CalcArea ()
        { return 1; }
        public void ShowArea()
        { }
    }
}
