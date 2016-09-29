using UnityEngine;
using System.Collections;

public class PlayerTP : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	Vector3 PlayerTPloc = new Vector3(0, 2, -29);
	
	// Update is called once per frame
	void Update ()
	{
		if (this.gameObject.transform.position.y < -5)
		{
			this.gameObject.transform.position = PlayerTPloc;
		}
	}
}
