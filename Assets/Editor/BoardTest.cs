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
			Board board = Board.NewEmpty();

			Vector3 expected = new Vector3 (0.5f, 0, 0);
			Assert.AreEqual(expected, board.positionForIndex(new Location(0,0)) );
		}

		[Test()]
		public void NewBoardIsEmpty(){
			Board board = new Board ();

			Assert.IsTrue (board.IsEmpty);
		}

		[Test()]
		public void TilesCollectionHasGetTileAndAddTile ()
		{
			Board board = Board.NewEmpty ();
			var location = new Location (0, 0);
			var tile = new Tile ();
			board.AddTile (location, tile);
			board.GetTile (location);
		}
	}
}

