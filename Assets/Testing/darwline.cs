using UnityEngine;
using System.Collections;
using Vectrosity;

public class darwline : MonoBehaviour {

	private VectorLine myLine;
	
	void Start () {
		myLine = VectorLine.SetLine (Color.green, RandomPoint(), RandomPoint());
	}
	
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			myLine.points2.Add (RandomPoint());
			myLine.Draw();
		}
	}
	
	
	Vector2 RandomPoint() {
		return new Vector2(Random.Range(0, Screen.width), Random.Range(0, Screen.height));
	}
	
}
