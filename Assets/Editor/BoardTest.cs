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
			Board board = new Board ();

			Vector3 expected = new Vector3 (0.5f, 0, 0);
			Assert.AreEqual(expected, board.positionForIndex(0,0) );
		}

		[Test()]
		public void NewBoardIsEmpty(){
			Board board = new Board ();

			Assert.IsTrue (board.IsEmpty);
		}
	}
}

