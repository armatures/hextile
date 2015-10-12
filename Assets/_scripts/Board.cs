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
			var hexagon = new []{
				new Location(-1,0), new Location (-1, 1),
				new Location(0,-1), new Location (0, 0),new Location (0, 1),
			new Location (1, 0),new Location (1, 1)};
			foreach (Location location in hexagon) {
				board.AddTile (instantiator, location, new Tile ());
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
			var row = location.Row;
			float oddColAdjustment = row % 2 == 0 ? 0 : -1f / 2;

			return new Vector3 (location.Col + oddColAdjustment,
			                   0,
				row * 0.87f
			);
		}

		public bool IsEmpty {
			get {
				return tiles.Count == 0;
			}
		}

		public void AddTile (IInstantiator instantiator, Location location, Tile tile)
		{
			tiles.Add (location, tile);
			var newTile = instantiator.InstantiateAtPosition (positionForIndex (location));
			newTile.name = location.summary ();
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

