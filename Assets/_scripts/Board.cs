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
			tiles = new Dictionary<Location, Tile>(){};
		}

		public static  Board Hexagon (int sideLength) {
			return new Board ();
		}

		public static Board NewEmpty(){
			var board = new Board ();
			board.AddTile (new Location (0, 0), new Tile ());
			return board;
		}

		public Vector3 positionForIndex(Location location) {
			var column = location.Col;
			float evenRowAdjustment = column % 2 == 0 ? 1f/2 : 0;
			float row3Adjustment = column == 2 ? -1f : 0;

			return new Vector3(location.Row*blenderUnit + evenRowAdjustment + row3Adjustment,
			                   0,
			                   column * 0.87f);
		}

		public bool IsEmpty {
			get {
				return tiles.Count == 0;
			}
		}

		public void AddTile(Location location, Tile tile){
			tiles.Add (location,tile);
		}

		public Tile GetTile(Location location)
		{
			return tiles [location];
		}
	}

	public class Tile{
	}
}

