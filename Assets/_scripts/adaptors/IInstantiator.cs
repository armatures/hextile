using UnityEngine;
using System;
namespace Adaptors
{
	public interface IInstantiator
	{
		UnityEngine.Object InstantiateAtPosition(Vector3 position);
		void init(GameObject objectToInstantiate, Quaternion rotation);
	}
}

