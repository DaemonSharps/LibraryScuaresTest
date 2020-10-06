using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAreas
{
    
    class Circle
    {
        delegate void ShowAr();
        private double Radius { get; set; }
        private double Area { get; set; }
        public Circle (double radius)
        {
            Radius = radius;
            Area=CalcArea(Radius);
        }
        private double CalcArea(double r)
        {
            double A = Math.PI * Math.Pow(r, 2);
            return A;
        }
        private void ShowArea(ShowAr show)
        {
            show?.Invoke(Area);
        }
    }
}
