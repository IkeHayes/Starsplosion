using UnityEngine;
using System.Collections;

public class collisionWallFire : MonoBehaviour {

	public GameObject shotHitFire;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "Wall")
		{
			Instantiate(shotHitFire, this.transform.position, shotHitFire.transform.rotation);
			Destroy(this.gameObject);
		}
	}
}
