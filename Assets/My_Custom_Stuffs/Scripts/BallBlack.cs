using UnityEngine;
using System.Collections;

public class BallBlack : MonoBehaviour {

	bool BallScoreAdded = false;

	int SpawnX;
	int SpawnY;
	int SpawnZ;

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
			if (ScoreUpdate.Score < 14)
			{
				ScoreUpdate.Score = 0;
				UIManager.Failed = true;
			}
			else
			{
				this.gameObject.transform.position = BallStorage;
			
				if (BallScoreAdded == false)
				{
					ScoreUpdate.Score ++;
					BallScoreAdded = true;

                    UIManager.Win = true;
				}
			}
		}
	}
}
