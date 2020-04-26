using UnityEngine;
using System.Collections;

public class PlayerPrefsScript : MonoBehaviour {


	const string SCORE = "score";
	const string TRAPSXPOSITION = "trapsxposition";
	const string TRAPSYPOSITION = "trapsyposition";

	public static void SetScore (float score){
		PlayerPrefs.SetFloat ("SCORE", score);
	}

	public static float GetScore(){
		return PlayerPrefs.GetFloat ("SCORE");
	}

	public static void SetPositionXPosition(float xPosition){
		PlayerPrefs.SetFloat ("TRAPSXPOSITION", xPosition);
	}

	public static float GetPositionXPosition(){
		return PlayerPrefs.GetFloat ("TRAPSXPOSITION");
	}

	public static void SetPositionYPosition(float yPosition){
		PlayerPrefs.SetFloat ("TRAPSYPOSITION", yPosition);
	}
	
	public static float GetPositionYPosition(){
		return PlayerPrefs.GetFloat ("TRAPSYPOSITION");
	}






	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
