using System;
using UnityEngine;

namespace Adaptors	
{
	public class Instantiator : MonoBehaviour { //basically wrapping and currying the static global Instantiate() method
		private Quaternion _rotation{ get; set; }
		private GameObject _objectToInstantiate{ get; set; }
		
		public Instantiator(GameObject objectToInstantiate, Quaternion rotation){
			_rotation = rotation;
			_objectToInstantiate = objectToInstantiate;
		}
		
		public UnityEngine.Object InstantiateAtPosition(Vector3 position){
			return Instantiate(_objectToInstantiate, position, _rotation);
		}
	} 
}