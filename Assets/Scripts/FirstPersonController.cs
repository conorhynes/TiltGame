using UnityEngine;
using System.Collections;

public class FirstPersonController : MonoBehaviour {

	public float mouseSensitivity = 5.0f;
	public float speedModifier = 5.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float forwardSpeed = Input.GetAxis ("Vertical") * speedModifier;
		float sideSpeed = Input.GetAxis ("Horizontal") * speedModifier;

		float rotationLR = Input.GetAxis ("Mouse X") * mouseSensitivity;

		transform.Rotate (0, rotationLR, 0);

		Vector3 speed = new Vector3 (sideSpeed, 0, forwardSpeed);

		speed = transform.rotation * speed;
		CharacterController cc = GetComponent<CharacterController> ();

		cc.SimpleMove (speed);
	}
}
