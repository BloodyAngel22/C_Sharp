using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test;

namespace BAExtensions 
{
	public static class Point2DExtensions{
		public static void Print(this Point2D point){
      point.Print();
    }
		public static bool IsEqual(this Point2D point1, Point2D point2){
			return point1.X == point2.X && point1.Y == point2.Y;
		}
	}
}