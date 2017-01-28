using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public GameObject localCamera;
	public GameObject vision;

	private Vector3 offset;

	void Start() {
		localCamera = GameObject.FindGameObjectWithTag("localCamera");

		//Vector3 newLocation = new Vector3(gameObject.transform.position.x, localCamera.transform.position.y, gameObject.transform.position.z);
		localCamera.transform.position = vision.transform.position;
		offset = localCamera.transform.position - gameObject.transform.position;
	}

	void LateUpdate() {
		localCamera.transform.position = gameObject.transform.position + offset;
	}
}
