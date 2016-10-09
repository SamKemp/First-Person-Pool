using UnityEngine;
using System.Collections;

public class Sun : MonoBehaviour
{

	// Use this for initialization
	void Start()
    {
        	
	}

    float toRadians(float One)
    {
        return One * Mathf.PI / 180f;
    }


    float SunDistance = 50;
    float SunAngle = 220;
    float SunSpeed = 10f;
    float SunAngle2;
    //Vector3 SunCenter = new Vector3(0, 0, 0);

	// Update is called once per frame
	void Update()
    {
        if (Time.timeScale == 1)
        {
            Vector3 SunLoc = new Vector3(0, 0, 0);
            SunLoc.x = SunDistance * Mathf.Cos(toRadians(SunAngle));
            SunLoc.y = SunDistance * Mathf.Sin(toRadians(SunAngle));

            this.gameObject.transform.position = SunLoc;

            this.gameObject.transform.eulerAngles = new Vector3(SunAngle - 180, 90, 0);

            SunAngle += SunSpeed * Time.deltaTime;

            if (SunAngle > 360)
            {
                SunAngle -= 360;
            }

        }
        else if (Time.timeScale == 0)
        {

        }
    }
}
