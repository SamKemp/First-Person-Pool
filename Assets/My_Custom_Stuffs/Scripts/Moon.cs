using UnityEngine;
using System.Collections;

public class Moon : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    float toRadians(float One)
    {
        return One * Mathf.PI / 180f;
    }


    float MoonDistance = 100;
    float MoonAngle = 140;
    float MoonSpeed = -10f;
    float MoonAngle2;
    Vector3 MoonCenter = new Vector3(0, 0, 0);

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 1)
        {
            Vector3 MoonLoc = new Vector3(0, 0, 0);
            MoonLoc.x = MoonDistance * Mathf.Cos(toRadians(MoonAngle - 180));
            MoonLoc.y = MoonDistance * Mathf.Sin(toRadians(MoonAngle - 180));

            this.gameObject.transform.position = MoonLoc;

            this.gameObject.transform.eulerAngles = new Vector3(MoonAngle - 180, 90, 0);

            MoonAngle += MoonSpeed * Time.deltaTime;

            if (MoonAngle > 360)
            {
                MoonAngle -= 360;
            }

        }
        else if (Time.timeScale == 0)
        {

        }
    }
}
