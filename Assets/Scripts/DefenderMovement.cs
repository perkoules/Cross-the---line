using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class DefenderMovement : MonoBehaviour {

	private int counter;
	private float defenderSpeed = 2;
	private float time = 150;
	private Animator animator;


	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {

		if (time == 0) {
			Movements ();
		} else {
			time --;
		}


	}

	void Movements (){
		if (Input.GetKey (KeyCode.RightArrow)) {
			animator.SetTrigger ("RightWalk");
			transform.position += Vector3.right * Time.deltaTime * defenderSpeed;
		} else if (Input.GetKey (KeyCode.LeftArrow)) {
			animator.SetBool ("LeftWalk", true);
			transform.position += Vector3.left * Time.deltaTime  * defenderSpeed;
		} else if (Input.GetKey (KeyCode.UpArrow)){
			animator.SetBool ("TopWalk", true);
			transform.position += Vector3.up * Time.deltaTime  * defenderSpeed;
		}else if (Input.GetKey (KeyCode.DownArrow)) {
			animator.SetBool ("DownWalk", true);
			transform.position += Vector3.down * Time.deltaTime * defenderSpeed;
		}else if (Input.GetKeyUp (KeyCode.RightArrow)  || Input.GetKeyUp (KeyCode.LeftArrow) || Input.GetKeyUp (KeyCode.UpArrow) || Input.GetKeyUp (KeyCode.DownArrow) ) {
			animator.SetBool ("Idle", true);
		}
	}

	void OnCollisionEnter2D(Collision2D col){
		//Destroy (gameObject);
	}


	
	



}
