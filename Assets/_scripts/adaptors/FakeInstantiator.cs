using System;
using UnityEngine;
using System.Collections.Generic;

namespace Adaptors
{
	public class FakeInstantiator : IInstantiator
	{
		public List<IUnityEngineObject> InstantiatedObjects;
		public IUnityEngineObject InstantiateAtPosition (Vector3 position)
		{
			var obj = new FakeUnityGameEngineObject ();
			InstantiatedObjects.Add (obj);
			return obj;
		}
		
		public void init (GameObject objectToInstantiate, Quaternion rotation)
		{
			
		}

		public FakeInstantiator ()
		{
			this.InstantiatedObjects = new List<IUnityEngineObject> ();
		}
	}
}

