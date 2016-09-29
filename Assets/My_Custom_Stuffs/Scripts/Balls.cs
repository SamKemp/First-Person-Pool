using UnityEngine;
using System.Collections;

public class Balls : MonoBehaviour {

	bool BallScoreAdded = false;
	
	int X;
	int Y;
	int Z;
	
	Vector3 BallStorage = new Vector3(0, -20, 0);
	Vector3 BallSpawn = new Vector3(0 , 0, 0);
	
	// Use this for initialization
	void Start ()
	{
		BallSpawn.x = this.gameObject.transform.position.x;
		BallSpawn.y = this.gameObject.transform.position.y;
		BallSpawn.z = this.gameObject.transform.position.z;
	}
	
	
	// Update is called once per frame
	void Update ()
	{
		if (this.gameObject.transform.position.y < -5)
		{
			this.gameObject.transform.position = BallStorage;

			if (BallScoreAdded == false)
			{
				ScoreUpdate.Score ++;
				BallScoreAdded = true;
			}
		}
	}

	public void isBlack(bool Black)
	{
		if (Black && ScoreUpdate.Score < 14)
		{
			ScoreUpdate.Score = 0;
			UIManager.Failed = true;
		}
	}
}
