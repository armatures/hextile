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
	}
}

