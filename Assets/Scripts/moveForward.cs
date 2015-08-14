using UnityEngine;
using System.Collections;

public class moveForward : MonoBehaviour {

	public float forwardSpeed = 5.0f;
	public GameObject shotHitFire;

	private Vector3 playerMoveDelta;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate () {
		float zMove = forwardSpeed*Time.fixedDeltaTime;
		playerMoveDelta.Set(0.0f, 0.0f, zMove);
		this.transform.position += playerMoveDelta;
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "Wall")
		{
			Instantiate(shotHitFire, this.transform.position, shotHitFire.transform.rotation);
		}
	}
}
