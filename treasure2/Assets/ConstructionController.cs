using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstructionController : MonoBehaviour {


	private Camera playerCamera;
	private GameObject itemObject;
	private float distance = 3.0f;

	// Use this for initialization
	void Start () {
		playerCamera = GetComponentInChildren<Camera>();

	}
	
	// Update is called once per frame
	void Update () {
		if ( itemObject != null ) {
			itemObject.transform.position = playerCamera.transform.position + playerCamera.transform.forward * distance;
			itemObject.transform.rotation = new Quaternion( 0.0f, playerCamera.transform.rotation.y, 0.0f, playerCamera.transform.rotation.w );
		}
	}
}
