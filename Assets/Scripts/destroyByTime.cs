using UnityEngine;
using System.Collections;

public class destroyByTime : MonoBehaviour {

	public float lifeSpan = 2.0f;

	private float killTime = 0.0f;
	private GameObject bullet;

	// Use this for initialization
	void Start () {
		bullet = this.gameObject;
		killTime = Time.time + lifeSpan;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time >= killTime) {
			Destroy(bullet);
		}
	}
}
