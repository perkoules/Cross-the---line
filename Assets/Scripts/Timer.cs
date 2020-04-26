using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour {

	private int  timeLeft = 0; 
	public float scoreTime;
	public LevelManager levelManager;
	private Text displayTimeLeft;

	// Use this for initialization
	void Start () {
		displayTimeLeft = GetComponent<Text> ();
		if (Application.loadedLevelName == "02_Level_01") {
			timeLeft = 100;
		}else if (Application.loadedLevelName == "02_Level_02") {
			timeLeft = 150;
		}else if (Application.loadedLevelName == "02_Level_03") {
			timeLeft = 200;
		}
	}
	
	// Update is called once per frame
	void Update () {
		scoreTime = timeLeft - Time.timeSinceLevelLoad;
		displayTimeLeft.text = (timeLeft - Time.timeSinceLevelLoad).ToString();
		if (timeLeft - Time.timeSinceLevelLoad <= 0) {
			levelManager.LoadLevel("03_Lose");
		}
	}
}
