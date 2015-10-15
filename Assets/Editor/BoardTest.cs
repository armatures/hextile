using System;
using NUnit.Framework;
using UnityEngine;

namespace Application
{
	[TestFixture()]
	public class BoardSpec
	{
		public Adaptors.FakeInstantiator instantiator;

		[SetUp()]
		public void Setup ()
		{
			this.instantiator = new Adaptors.FakeInstantiator ();		
		}

		[Test()]
		public void PositionForOriginIsAbsolute ()
		{
			Vector3 expected = new Vector3 (0, 0, 0);
			Assert.AreEqual (expected, Board.positionForIndex (new Location (0, 0)));
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
			board.AddTile (instantiator, new Location (0, 0), tile);
			var fetchedTile = board.GetTile (new Location (0, 0));
			Assert.AreEqual (tile, fetchedTile);
		}

		[Test()]
		public void HexagonGivesABoardWithOriginPopulated ()
		{
			var board = Board.Hexagon (1, instantiator);
			Assert.NotNull (board.GetTile (new Location (0, 0)));
		}

		[Test()]
		public void InstantiatorIsCalled7TimesForForTheSmallHexagonConstructor()
		{
			Board.Hexagon (1, instantiator);
			Assert.AreEqual (7, instantiator.InstantiatedObjects.Count);
			
			//			foreach (var obj in instantiator.InstantiatedObjects) {
//				Console.WriteLine (obj.name);
//			}
		}
		
		[Test()]
		public void InstantiatorIsCalled19TimesForForTheLargerHexagonConstructor()
		{
			Board.Hexagon (2, instantiator);
			Assert.AreEqual (19, instantiator.InstantiatedObjects.Count);
		}
	}
}
