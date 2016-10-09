using UnityEngine;
using UnityEngine.UI;

public class FPS : MonoBehaviour
{
	float DeltaTime = 0.0f;

	// Use this for initialization
	void Start()
	{
	}

	void Update()
	{
		DeltaTime += (Time.deltaTime - DeltaTime) * 0.1f;
		float fps = 1.0f / DeltaTime;

		GetComponent<Text> ().text = "FPS: " + ((int)fps);

		if (FPSToggle.isFPSToggled) {
			GetComponent<Text> ().enabled = true;
		} else {
			GetComponent<Text>().enabled = false;
		}
	}

}