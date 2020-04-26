using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public GameObject projectile;
	public GameObject gun;
	private GameObject projectileParent;
	private Animator animator;
	
	void Start (){
		projectileParent = GameObject.Find("Projectiles");
		animator = GameObject.FindObjectOfType<Animator> ();
		if (!projectileParent) {
			projectileParent = new GameObject();
			projectileParent.name = "Projectiles";
		}
	}
	
	void Update(){
		animator.SetBool ("kkkk", true);
	}

	private void Fire(){
		GameObject newProjectile = Instantiate (projectile) as GameObject;
		newProjectile.transform.parent = projectileParent.transform;
		newProjectile.transform.position = gun.transform.position;
	}
}
