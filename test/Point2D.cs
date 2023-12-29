using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test
{
	public partial class Point2D
	{
		private static int id;
		public static int ID { get => id; }
		private int _x;
		private int _y;
		private int curId;

		public const int TMP = 100; // constant && static
		public readonly int TMP_; // readonly && not static && first declaration
		public static readonly int TMP2 = 100; // readonly && static && first declaration

		static Point2D(){
			id = 1;
		}
		public Point2D()
		{
			_x = 0;
			_y = 0;
      curId = id++;
			TMP_ = TMP;
		}
		public Point2D(int x, int y)
		{
			this._x = x;
			this._y = y;
			curId = id++;
			TMP_ = TMP;
		}
		public static void SetId(int value){
			id = value;
		}
		public void SetCoordinate(int x, int y)
		{
			this._x = x;
			this._y = y;
		}
		public int X
		{
			get { return _x; }
			set { _x = value; }
		}
		public int Y { get => _y; set => _y = value; }
	}

}