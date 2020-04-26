using UnityEngine;
using System.Collections;

public class ReturnPlayerToOriginalPosition : MonoBehaviour {


	public GameObject defender;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D col){
		defender.transform.position = new Vector3 (0, 3, 0);
	}
}
