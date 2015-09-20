using UnityEngine;
using System.Collections;
using Adaptors;

namespace Application
{
	public class GameController : MonoBehaviour
	{
		public GameObject basicHex;

		void Start ()
		{
			Quaternion baseRotation = new Quaternion (0, 0, 0, 0);
			IInstantiator instantiator = ScriptableObject.CreateInstance<Instantiator> () as Instantiator;
			instantiator.init (basicHex, baseRotation);
			Board.Hexagon (3, instantiator);
		}
	}
}