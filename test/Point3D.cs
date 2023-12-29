using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test
{
    public class Point3D
    {
			private int _x;
			private int _y;
			private int _z;

      public Point3D(int x, int y, int z){
				_x = x;
				_y = y;
				_z = z;				
			}

			public void Print(){
				Console.WriteLine($"X: {_x}, Y: {_y}, Z: {_z}");
			}
			public void setX(int x){
				_x = x;
			}
			public void setY(int y){
        _y = y;
      }
			public void setZ(int z){
        _z = z;
      }
			public void SetCoordinate(int x, int y, int z){
				_x = x;
        _y = y;
        _z = z;
			}
			public int getX(){
				return _x;
			}
    }
}