using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public float rotationSpeed;
	public GameObject[] levels;
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.forward * Time.deltaTime * rotationSpeed * Input.GetAxis("Horizontal"));
	}
}
