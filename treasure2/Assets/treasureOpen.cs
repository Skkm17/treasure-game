using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treasureOpen : MonoBehaviour {
	private Animation ani;
	// Use this for initialization
	void Start () {
		ani = GetComponent<Animation>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void open(){

		if (!ani.isPlaying) {
			ani.Play ();
		} else {
		
			ani.Stop ();
		}
	}
}
