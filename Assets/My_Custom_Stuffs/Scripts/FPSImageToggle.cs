using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FPSImageToggle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (FPSToggle.isFPSToggled)
		{
			GetComponent<Image>().enabled = true;
		}
		else
		{
			GetComponent<Image>().enabled = false;
		}
	}
}
