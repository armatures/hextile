using System;
using NUnit.Framework;

namespace Application
{
	[TestFixture()]

	public class LocationTest
	{
			[Test()]
		public void LocationEqualityDependsOnArguments(){
			Assert.AreEqual (new Location(1, 1), new Location(1, 1));
		}

		[Test()]
		public void LocationsAreNotEqualWithDifferentArguments(){
			Assert.AreNotEqual (new Location(0, 0), new Location(1, 1));
		}

		[Test()]
		public void CubeCoordinatesLocationConvertsBackAndForth(){
			Assert.AreEqual (new Location (0, 0), new Location(0, 0, 0));
			var hex = new Location (-3, 2);
			var cube = hex.CubeCoordinates ();
			Assert.AreEqual (hex, CubeCoordinates.LocationFor (cube.x,cube.y,cube.z));
		}
	}
}

