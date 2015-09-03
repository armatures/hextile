using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	public GameObject basicHex;

	private int[] tileLayout = new int[]{3,4,5,4,3};
	private Application.Board board = new Application.Board();

	// Use this for initialization
	void Start () {
		Quaternion baseRotation = new Quaternion (0, 0, 0, 0);
		for (int z = 0; z<tileLayout.Length; z++)
		{
			for(int x = 0; x<tileLayout[z];x++)
			{
				Vector3 position = board.positionForIndex(x,z);
				Debug.Log ("color: " + basicHex.renderer.material.color);
//				if(x == 2) {
//					GameObject clone = (GameObject) Instantiate(basicHex, position, baseRotation);
//					clone.renderer.material.SetColor("_Color", Color.blue);
//				} else {
					Instantiate(basicHex, position, baseRotation);
//				}
			}
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}
