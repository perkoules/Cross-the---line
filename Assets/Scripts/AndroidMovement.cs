using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AndroidMovement : MonoBehaviour {


	private float holdTime,defenderSpeed = 2f;
	public GameObject defender;
	Animator animator;

	void Start(){
		animator = defender.GetComponent<Animator> ();
	}


	public void OnPointerDown(){
		StartCoroutine ("StartCountingMovement");
	}

	public void OnPointerUp(){
		StopCoroutine ("StartCountingMovement");
	}

	IEnumerator StartCountingMovement(){
		if (gameObject.tag == "ButtonUp") {
			for (holdTime = 0f; holdTime<12f; holdTime += Time.deltaTime) {
				animator.SetBool ("TopWalk", true);
				defender.transform.position += Vector3.up * Time.deltaTime * defenderSpeed;
				yield return new WaitForSeconds (Time.deltaTime);
			}
			holdTime = 1f;
		}else if (gameObject.tag == "ButtonDown") {
			for (holdTime = 0f; holdTime<12f; holdTime += Time.deltaTime) {
				animator.SetBool ("DownWalk", true);
				defender.transform.position += Vector3.down * Time.deltaTime * defenderSpeed;
				yield return new WaitForSeconds (Time.deltaTime);
			}
			holdTime = 1f;
		}if (gameObject.tag == "ButtonRight") {
			for (holdTime = 0f; holdTime<12f; holdTime += Time.deltaTime) {
				animator.SetBool ("RightWalk", true);
				defender.transform.position += Vector3.right * Time.deltaTime * defenderSpeed;
				yield return new WaitForSeconds (Time.deltaTime);
			}
			holdTime = 1f;
		}else if (gameObject.tag == "ButtonLeft") {
			for (holdTime = 0f; holdTime<12f; holdTime += Time.deltaTime) {
				animator.SetBool ("LeftWalk", true);
				defender.transform.position += Vector3.left * Time.deltaTime * defenderSpeed;
				yield return new WaitForSeconds (Time.deltaTime);
			}
			holdTime = 1f;
		}
	}
}
