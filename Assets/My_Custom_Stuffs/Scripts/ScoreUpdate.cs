using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreUpdate : MonoBehaviour {

	public static int Score = 0;

	Text ScoreTXT;

	// Use this for initialization
	void Start ()
	{
		ScoreTXT = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Time.timeScale == 1)
		{
			ScoreTXT.text = "Score: " + Score;
		}
	}
}
