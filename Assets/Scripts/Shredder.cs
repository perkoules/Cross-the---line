using UnityEngine;
using System.Collections;

public class Shredder : MonoBehaviour {

	public LevelManager levelManager;

	void OnTriggerEnter2D(Collider2D col){
		GameObject tmpObj = GameObject.FindGameObjectWithTag ("Defender");
		tmpObj.transform.position = new Vector3 (0, 3, 0);
		GameObject tmpObjLives = GameObject.FindGameObjectWithTag("Live");
		Destroy (tmpObjLives);
		if (!tmpObjLives) {
			Destroy(tmpObj);
			levelManager.LoadLevel("03_Lose");
		}
	}
}
