using System;
using UnityEngine;

namespace Adaptors
{
	public class FakeInstantiator : IInstantiator
	{
		public UnityEngine.Object InstantiateAtPosition (Vector3 position)
		{
			return new UnityEngine.Object ();
		}
		
		public void init (GameObject objectToInstantiate, Quaternion rotation)
		{
			
		}

		public FakeInstantiator ()
		{
		}
	}
}

