using System;
using System.Collections.Generic;
using UnityEngine;
using Adaptors;

namespace Application
{
	public class Board
	{
		private Dictionary<Location,Tile> tiles;

		public Board ()
		{
			tiles = new Dictionary<Location, Tile> (){};
		}

		public static Board Hexagon (int sideLength, IInstantiator instantiator)
		{
			var board = new Board ();
			var hexagon = new []{new Location (0, 0),new Location (0, 1),new Location (0, 2),
			new Location (1, 0),new Location (1, 1),new Location (1, 2),
				new Location (2, 1)};
			foreach (Location location in hexagon) {
				board.AddTile (location, new Tile ());
				instantiator.InstantiateAtPosition(positionForIndex(location));
			}
			return board;
		}

		public static Board NewEmpty ()
		{
			var board = new Board ();
			return board;
		}

		public static Vector3 positionForIndex (Location location)
		{
			var column = location.Col;
			float evenRowAdjustment = column % 2 == 0 ? 1f / 2 : 0;
			float row3Adjustment = column == 2 ? -1f : 0;

			return new Vector3 (location.Row + evenRowAdjustment + row3Adjustment,
			                   0,
			                   column * 0.87f);
		}

		public bool IsEmpty {
			get {
				return tiles.Count == 0;
			}
		}

		public void AddTile (Location location, Tile tile)
		{
			tiles.Add (location, tile);
		}

		public Tile GetTile (Location location)
		{
			return tiles [location];
		}
	}

	public class Tile
	{
	}
}

