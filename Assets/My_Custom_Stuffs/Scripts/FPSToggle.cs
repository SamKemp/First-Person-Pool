using UnityEngine;
public class FPSToggle : MonoBehaviour
{
    public static bool isFPSToggled = false;
    // Use this for initialization
    void Start ()
    {
    }
    // Update is called once per frame
    void Update ()
    {
    }
    void Toggle()
    {
        isFPSToggled = !isFPSToggled;
    }
}