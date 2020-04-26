using UnityEngine;
using System.Collections;

public class WinCondition : MonoBehaviour {

	public LevelManager levelManager;
	public Timer tim;
	public float scoreAfterWin = 0;

	void Start(){
		tim.GetComponent<Timer> ();
		scoreAfterWin = PlayerPrefsScript.GetScore ();
	}

	void OnTriggerEnter2D(Collider2D col){
		float scoreTimeGet = tim.scoreTime;
		GameObject[] tmpObjLives = GameObject.FindGameObjectsWithTag ("Live");
		scoreAfterWin += scoreTimeGet + (tmpObjLives.Length * 100);
		PlayerPrefsScript.SetScore (scoreAfterWin);
		levelManager.LoadNextLevel ();
	}
	

}
