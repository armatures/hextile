// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------
using System;
using NUnit.Framework;
using UnityEngine;

namespace Application
{
	[TestFixture()]
	public class BoardSpec
	{
		[Test()]
		public void TestCase ()
		{
			Board board = new Board ();

			Vector3 expected = new Vector3 (0.5f, 0, 0);
			Assert.AreEqual(expected, board.positionForIndex(0,0) );
		}
	}
}

