﻿using UnityEngine;
using System.Collections;

public class movementController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.position += transform.forward*0.2f;
	}
}
