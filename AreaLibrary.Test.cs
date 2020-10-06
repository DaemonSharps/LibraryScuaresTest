using System;
using Xunit;

namespace LibraryAreas
{
    public class ShapeTest
    {
        [Fact]
        public void CircleAreaTest()
        {   //Arrange
            
            double[] Radius = new double[5] { 0.5, 1.1, 3, 4.9213, 5 };

            
            //Act and Assert
            for(int i=0;i<Radius.Length-1;i++)
            { double result = Math.PI * Math.Pow(Radius[i], 2);
                Shape Circle = new Shape(Radius[i]);
                Assert.Equal(Circle.Area,result);

            }

        }
        [Fact]
        public void TriangleAreaTest()
        {
            //Arrange
            double[,] sides = new double[4, 3] { { 4, 3, 6 }, { 3, 4, 5 }, { 3, 3, 5 }, { 12, 5, 13 } };
            //Act and Assert
            for (int i=0;i<4;i++)
            { double P=0;
                for(int j=0;j<3;j++)
                {
                    P+=sides[i,j]; 
                }
                Shape Triangle = new Shape(sides[i,0],sides[i,1],sides[i,2]);
                double result1 = Math.Sqrt(P * (P - sides[i, 0]) * (P - sides[i, 1]) * (P - sides[i, 2]));
                bool result2 = (Math.Pow(sides[i, 0],2)== Math.Pow(sides[i, 1], 2)+ Math.Pow(sides[i, 2], 2)) || (Math.Pow(sides[i, 1], 2) == Math.Pow(sides[i, 0], 2) + Math.Pow(sides[i, 2], 2)) || (Math.Pow(sides[i, 2], 2) == Math.Pow(sides[i, 1], 2) + Math.Pow(sides[i, 0], 2));
                Assert.Equal(Triangle.Area,result1);
                Assert.Equal(Triangle.isRightTriangle(),result2);
            }
        }
        [Fact]
        public void PolygonAreaTest()
        {   //Arrange
            int[,] sides = new int[5, 2] { { 3, 2 }, { 3, 123 }, { 8, 14 }, { 90, 2 }, { 53, 3 } };
            //Act and Assert
            for(int i=0;i<5; i++)
            {
                Shape Polygon = new Shape(sides[i,0],sides[i,1]);
                double result = sides[i, 0] * Math.Pow(sides[i, 1],2) / (4 * Math.Tan(Math.PI / sides[i, 0]));
                Assert.Equal(Polygon.Area,result);
            }
        }
        
    }
}
