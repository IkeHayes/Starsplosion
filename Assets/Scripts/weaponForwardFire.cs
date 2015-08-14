using UnityEngine;
using System.Collections;

public class weaponForwardFire : MonoBehaviour {

	public Rigidbody bulletPlayer;
	public float bulletVelocity = 100.0f;
	public Light wepFlash;
	public float wepFlashDuration = 0.1f;
	
	private bool flashActive = false;
	private float offTime = 0.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown("Fire1")) {
			//Instantiate a new bullet
			Rigidbody newBullet = Instantiate(bulletPlayer, transform.position, transform.rotation) as Rigidbody;
			newBullet.AddForce(transform.forward*bulletVelocity, ForceMode.VelocityChange);
			//Set light flash active and calculate future flash off time
			flashActive = true;
			wepFlash.enabled = true;
			offTime = Time.time + wepFlashDuration;
		}

		//If weapon flash is active and the current time is greater than the duration disable the light
		if (flashActive==true && Time.time > offTime) {
			flashActive = false;
			wepFlash.enabled = false;
		}
	}
}
