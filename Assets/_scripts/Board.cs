using System;
using System.Collections.Generic;
using UnityEngine;

namespace Application
{
	public class Board
	{
		private float blenderUnit = 1f;
		private Dictionary<Location,Tile> tiles;
		public Board ()
		{
			tiles = new Dictionary<Location,Tile>{};
		}

		public Vector3 positionForIndex(int row, int column) {
			float evenRowAdjustment = column % 2 == 0 ? 1f/2 : 0;
			float row3Adjustment = column == 2 ? -1f : 0;

			return new Vector3(row*blenderUnit + evenRowAdjustment + row3Adjustment,
			                   0,
			                   column * 0.87f);
		}

		public bool IsEmpty {
			get {
				return tiles.Count == 0;
			}
		}
	}

	public class Tile{
	}

	public class Location{}
}

