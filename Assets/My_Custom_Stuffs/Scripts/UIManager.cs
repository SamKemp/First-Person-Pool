using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.Analytics;
using System.Collections.Generic;

public class UIManager : MonoBehaviour
{
	
	GameObject[] pauseObjects;
	GameObject[] failObjects;
    GameObject[] winObjects;
    GameObject[] MobileInput;

	public static bool Failed = false;
    public static bool Win = false;

    float Version = 1.5f;

	string Username;

    // Use this for initialization
    void Start ()
	{
		Failed = false;
		Time.timeScale = 1;
		pauseObjects = GameObject.FindGameObjectsWithTag("ShowOnPause");
		hidePaused();
		failObjects = GameObject.FindGameObjectsWithTag("ShowOnFail");
		hideFailed();
        winObjects = GameObject.FindGameObjectsWithTag("ShowOnWin");
        hideWin();
        MobileInput = GameObject.FindGameObjectsWithTag("MobileInput");
		if (Application.platform == RuntimePlatform.Android) {
			showMobile ();
		} else {
			hideMobile ();
		}

	}
	
	// Update is called once per frame
	void Update ()
	{

        //uses the Escape button to pause and unpause the game
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                showPaused();
            }
            else if (Time.timeScale == 0)
            {
                Debug.Log("high");
                Time.timeScale = 1;
                hidePaused();
            }
        }
		if (Failed)
		{
			showFailed();
		}
        if(Win)
        {
            showWin();
        }
	}
	
	
	//Reloads the Level
	public void Reload()
	{
		hideFailed();
        hideWin();
        Application.LoadLevel(Application.loadedLevel);
	}

	//Quits the Game
	public void Quit()
	{
		Application.Quit();
	}

	//controls the pausing of the scene
	public void pauseControl()
	{
		if(Time.timeScale == 1)
		{
			Time.timeScale = 0;
			showPaused();
		} else if (Time.timeScale == 0){
			Time.timeScale = 1;
			hidePaused();
		}
	}
	
	//shows objects with ShowOnPause tag
	public void showPaused(){
		foreach(GameObject g in pauseObjects){
			g.SetActive(true);
		}
	}
	
	//hides objects with ShowOnPause tag
	public void hidePaused(){
		foreach(GameObject g in pauseObjects){
			g.SetActive(false);
		}
	}

	//shows objects with failObjects tag
	public void showFailed()
	{
		Time.timeScale = 0;
		foreach(GameObject g in failObjects){
			g.SetActive(true);
		}
	}

	//hides objects with failObjects tag
	public void hideFailed(){
		foreach(GameObject g in failObjects){
			g.SetActive(false);
		}
	}

    //shows objects with ShowOnWin tag
    public void showWin()
    {
        Time.timeScale = 0;
        foreach (GameObject g in winObjects)
        {
            g.SetActive(true);
        }
    }

    //hides objects with ShowOnWin tag
    public void hideWin()
    {
        foreach (GameObject g in winObjects)
        {
            g.SetActive(false);
        }
    }

    //shows objects with MobileInput tag
    public void showMobile()
	{
		foreach(GameObject h in MobileInput){
			h.SetActive(true);
		}
	}

	//hides objects with MobileInput tag
	public void hideMobile()
	{
		foreach(GameObject h in MobileInput){
			h.SetActive(false);
		}
	}
	
	//loads inputted level
	public void LoadLevel(string level)
    {
        //Tracks which level was selected
		Analytics.CustomEvent("LoadLevel", new Dictionary<string, object> {{"Version", Version},{"Level", level}});
        
        //Switched level
		Application.LoadLevel(level);
	}
	
}
