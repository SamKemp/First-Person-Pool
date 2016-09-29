using UnityEngine;
using UnityEngine.Analytics;
using System.Collections;
using System.Collections.Generic;

public class AnalysisTutorial : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
		Gender gender = Gender.Female;
		Analytics.SetUserGender(gender);
		
		int birthYear = 2014;
		Analytics.SetUserBirthYear(birthYear);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
