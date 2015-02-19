using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	public GameObject basicHex;

	private float blenderUnit = 1.74f;
	private int[] tileLayout = new int[]{3,4,5,4,3};

	// Use this for initialization
	void Start () {
		Quaternion baseRotation = new Quaternion (0, 90, 90, 0);
		for (int z = 0; z<tileLayout.Length; z++)
		{
			for(int x = 0; x<tileLayout[z];x++)
			{
				Vector3 position = positionForIndex(x,z);
				Instantiate(basicHex, position, baseRotation);
			}
		}
	}

	Vector3 positionForIndex(int row, int column) {
		float evenRowAdjustment = column % 2 == 0 ? blenderUnit/2 : 0;
		float row3Adjustment = column == 2 ? -blenderUnit : 0;
		
		return new Vector3(row*blenderUnit + evenRowAdjustment + row3Adjustment,
		                   0,
		                   column*blenderUnit * 0.87f);
	}

	// Update is called once per frame
	void Update () {
	
	}


}
