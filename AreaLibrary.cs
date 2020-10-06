using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAreas
{
     class Shape
    {
        public delegate void ShowAr(double Area);
        private ShowAr _show=null;
        private double Area { get; set; }
        private double Radius { get; set; }
        private double side1 { get; set; }
        private double side2 { get; set; }
        private double side3 { get; set; }

        public void ShowArea()
        {
            _show(Area);
        }
        public void RegDelegate(ShowAr show) // add your metod how to show Area with this function
        {
            _show = show;
        }
        private double CircleArea(double R)
        {
            double A = Math.PI * Math.Pow(R, 2);
            return A;
        }
        private double TriangleArea(double a1, double a2, double a3)
        {
           
                side1 = a1;
                side2 = a2;
                side3 = a3;

                double P = a1 + a2 + a3;
                double A = Math.Sqrt(P * (P - a1) * (P - a2) * (P - a3));
                return A;
            
          
            
            
        }
        public bool isRightTriangle()// check if the triangle is right-angle
        {
            if (side1 != 0 & side2 != 0 & side3 != 0)
            {
                bool ex1 = (Math.Pow(side1, 2) + Math.Pow(side2, 2) == Math.Pow(side3, 2));
                bool ex2 = (Math.Pow(side2, 2) + Math.Pow(side3, 2) == Math.Pow(side1, 2));
                bool ex3 = (Math.Pow(side3, 2) + Math.Pow(side1, 2) == Math.Pow(side2, 2));
                return ex1 || ex2 || ex3;
            }
            return false;
           
        }
        private bool isTriangle(double a1, double a2,double a3)
        {
            bool ex1 = (a1 + a2) > a3;
            bool ex2 = (a2 + a3) > a1;
            bool ex3 = (a1 + a3) > a2;
            return ex1 & ex2 & ex3;
        }
        
        private double PolygonArea(int sideCount, double side)// exapmle how to add new figure
        {
           
                double A1 = sideCount * Math.Pow(side, 2);
                double A2 = 4 * Math.Tan(Math.PI / 4);
                double A = A1 / A2;
                return A;
            
        }
        public Shape(double radius)
        {
            Radius = radius;
            if(Radius<0)
            {
                throw new Exception("Radius should be more than zero.");
            }
            else
            {
                Area = CircleArea(Radius);
            }
            
        }


        public Shape(double side1, double side2, double side3)
        { if(side1<0||side2<0||side3<0)
            {
                throw new Exception("Sides shoul be more than zero.");
            }
            else
            {
                if (isTriangle(side1, side2, side3))
                {
                    Area = TriangleArea(side1, side2, side3);
                }
                else
                {
                    throw new Exception("Triangle does not exist.");
                }

            }
            
        }
        public Shape(int SideCount, double Side)// add new figure, example
        { 
            if(SideCount<3||Side<0)
            {
                throw new Exception("Sides shoul be more than zero and side count more than 2.");
            }
            else
            {
                Area = PolygonArea(SideCount, Side);
            }
            
            
        }
        
    }
   
  
    
}
