using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreDisplay : MonoBehaviour {


	// Use this for initialization
	void Start () {
		gameObject.GetComponent<Text> ().text = PlayerPrefsScript.GetScore ().ToString(); 
	}
	
	// Update is called once per frame
	void Update () {
	
	}


}
