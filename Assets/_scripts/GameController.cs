using UnityEngine;
using System.Collections;
using Adaptors;

namespace Application {

public class GameController : MonoBehaviour {
	public GameObject basicHex;

	private int[] tileLayout = new int[]{3,4,5,4,3};
	private Application.Board board = new Application.Board();

	void Start () {
		Quaternion baseRotation = new Quaternion (0, 0, 0, 0);
			Instantiator instantiator = ScriptableObject.CreateInstance<Instantiator> () as Instantiator;
			instantiator.init(basicHex, baseRotation);

		for (int z = 0; z<tileLayout.Length; z++)
		{
			for(int x = 0; x<tileLayout[z];x++)
			{
				Vector3 position = board.positionForIndex(new Location(x,z));
				instantiator.InstantiateAtPosition(position);
			}
		}
	}
	}
}