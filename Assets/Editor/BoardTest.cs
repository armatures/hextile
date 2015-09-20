using System;
using NUnit.Framework;
using UnityEngine;

namespace Application
{
	[TestFixture()]
	public class BoardSpec
	{
		[Test()]
		public void PositionForOriginIsAbsolute ()
		{
			Board board = Board.NewEmpty ();

			Vector3 expected = new Vector3 (0.5f, 0, 0);
			Assert.AreEqual (expected, board.positionForIndex (new Location (0, 0)));
		}

		[Test()]
		public void NewBoardIsEmpty ()
		{
			Board board = new Board ();

			Assert.IsTrue (board.IsEmpty);
		}

		[Test()]
		public void TilesCollectionHasGetTileAndAddTile ()
		{
			Board board = Board.NewEmpty ();
			var tile = new Tile ();
			board.AddTile (new Location (0, 0), tile);
			var fetchedTile = board.GetTile (new Location (0, 0));
			Assert.AreEqual (tile, fetchedTile);
		}

		[Test()]
		public void HexagonGivesABoardWithOriginPopulated ()
		{
			var board = Board.Hexagon (3);
			Assert.NotNull (board.GetTile (new Location (0, 0)));
		}

		[Test()]
		public void HexagonGivesABoardFullyPopulated ()
		{
			var board = Board.Hexagon (3);
			var allTiles = new []{
				new Location (0, 0),new Location (0, 1),new Location (0, 2),
				new Location (1, 0),new Location (1, 1),new Location (1, 2),
								  new Location (2, 1)
			};
			foreach (Location location in allTiles) {
				//Debug.Log(location.Col);
				Assert.DoesNotThrow (
					() => board.GetTile (location),
					String.Format ("no tile found at location {0}, {1}", location.Row, location.Col)
				);
			}
		}
	}
}
