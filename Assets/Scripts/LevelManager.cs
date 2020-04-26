using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public float autoLoadNextLevelAfter;
	/*public Toggle toggle;*/

	void Start(){
		/*toggle = GetComponent<Toggle> ();
		if (toggle.isOn) {
			print ("hhhhh");
		}*/

		if (autoLoadNextLevelAfter <= 0) {
			Debug.Log ("HEY Where is AutoLoad?");
		} else {
			Invoke ("LoadNextLevel", autoLoadNextLevelAfter);

		}

	}

	public void QuitRequest(){
		Application.Quit ();
	}

	public void LoadLevel(string name) {
		Application.LoadLevel (name);
		PlayerPrefsScript.SetScore (0);
	}

	public void LoadNextLevel(){
		Application.LoadLevel (Application.loadedLevel + 1);
	}



}
