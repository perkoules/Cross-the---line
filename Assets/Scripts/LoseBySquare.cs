using UnityEngine;
using System.Collections;

public class LoseBySquare : MonoBehaviour {

	private Color tmp;
	private GameObject clon;
	public LevelManager levelManager;

	// Use this for initialization
	void Start () {
		clon = GameObject.FindGameObjectWithTag("Defender");
		tmp = GetComponent<SpriteRenderer> ().color;
		tmp.a = 0f;
		GetComponent<SpriteRenderer> ().color = tmp;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D col){
		tmp.a = 100f;
		GetComponent<SpriteRenderer> ().color = tmp;
		GameObject tmpObj = GameObject.FindGameObjectWithTag ("Defender");
		tmpObj.transform.position = new Vector3 (0, 3, 0);
		Destroy(this);
		GameObject tmpObjLives = GameObject.FindGameObjectWithTag("Live");
		Destroy (tmpObjLives);
		if (!tmpObjLives) {
			Destroy(tmpObj);
			levelManager.LoadLevel("03_Lose");
		}
		 
	}
}
