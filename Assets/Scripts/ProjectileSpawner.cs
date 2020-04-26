using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ProjectileSpawner : MonoBehaviour {

	private float projectileRange;
	public GameObject projectile;
	private GameObject parent;
	private GameObject store;
	private GameObject projShoot;
	private float seconds = 1, STimer;

	void Start(){
		parent = GameObject.Find("Projectiles");
		if (!parent) {
			parent = new GameObject();
			parent.name = "Projectiles";
		}
	}

	// Update is called once per frame
	void Update () {
		STimer -= Time.deltaTime;
		if (STimer <= 0)
		{
			Spawn(projShoot);
			STimer = 2f;
		}

	}


	
	void Spawn (GameObject myGameobject){

		projectileRange = Random.Range (1f, 5f);
		//projectileRange = Mathf.RoundToInt (projectileRange);
		Vector3 position = new Vector3 (11f, projectileRange, 0f);
		store = Instantiate (projectile,position,Quaternion.identity) as GameObject;
		store.transform.parent = parent.transform;
		store.gameObject.tag = "ProjectilesToBeRemoved";
	}
	
	bool SpawnDelay(GameObject projGameObject){

		float spawnPerSecond = 5 / seconds;
		float threshold = spawnPerSecond * Time.deltaTime;

		return (Random.value < threshold);
	}
}
