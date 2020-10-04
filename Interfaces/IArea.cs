using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAreas.Interfaces
{
    public interface Area
    {
        double Area { get; set; }
        double CalcArea();
        void ShowArea();

    }
}
