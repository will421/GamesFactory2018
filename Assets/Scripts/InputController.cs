using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour {

	public float maxRotationSpeed = 90f;

	private Rigidbody2D myRigidbody2D; 
	
	void Start(){
		myRigidbody2D = gameObject.GetComponent<Rigidbody2D>();
	}

	void FixedUpdate () {
		float move = Input.GetAxis("Horizontal");
		myRigidbody2D.angularVelocity = maxRotationSpeed * move;
	}
}
