using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour
{
	public float lateralSpeed = 6.0f;
	public float minX = -9.0f, maxX = 9.0f;
	public float minY = -4.5f, maxY = 5.0f;
	public float maxRotate = 20.0f;

	private int invert = -1;
	private Vector3 movement;
	private Vector3 newPosition;
	private Quaternion shipDirection;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

	void FixedUpdate (){
		//Get player movement
		float hMove = Input.GetAxis("Horizontal");
		float vMove = Input.GetAxis("Vertical");
		movement.Set(hMove*lateralSpeed*Time.fixedDeltaTime, vMove*0.80f*lateralSpeed*Time.fixedDeltaTime*invert, 0.0f);
		newPosition = this.transform.position + movement;

		//Clamp ship to the screen
		Mathf.Clamp(newPosition.x, minX, maxX);
		Mathf.Clamp(newPosition.y, minY, maxY);

		//Move ship using input
		this.transform.position = newPosition;

		//Rotate ship with movement
		shipDirection = Quaternion.Euler (vMove * maxRotate, hMove * maxRotate, 0.0f);
		this.transform.rotation = Quaternion.RotateTowards (this.transform.rotation, shipDirection, 100.0f*Time.fixedDeltaTime);
	}
	
}