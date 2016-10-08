using UnityEngine;
using System.Collections;

public class MenuCamera : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}


    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 1)
        {
            GetComponent<Camera>().transform.RotateAround(Vector3.zero, Vector3.up, 20 * Time.deltaTime);
        }
        else if (Time.timeScale == 0)
        {

        }
    }
}
