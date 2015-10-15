	using System;
namespace Application
{
	public class CubeCoordinates
	{
		public CubeCoordinates (int x, int y, int z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		public CubeCoordinates (int offsetRow, int offsetCol){
			// convert even-r offset to cube
			this.x = offsetCol - (offsetRow + (offsetRow & 1)) / 2;
			this.z = offsetRow;
			this.y = -this.x - this.z;
		}

		public static Location LocationFor(int x, int y, int z){
			// convert cube to even-r offset
			var col = x + (z + (z & 1)) / 2;
			var row = z;
			return new Location (row, col);
		}

		public readonly int x;
		public readonly int y;
		public readonly int z;
	}
}

