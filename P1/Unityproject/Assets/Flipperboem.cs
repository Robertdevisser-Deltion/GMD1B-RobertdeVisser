﻿using UnityEngine;
using System.Collections;

public class Flipperboem : MonoBehaviour {

    public float flipperStrength;
    public float pushForce;
    private HingeJoint hinge; 

	// Use this for initialization
	void Start () {
        hinge = GetComponent<HingeJoint>(); 
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetButtonDown("Jump")) {
            Vector3 f = transform.up * flipperStrength;
            Vector3 p = (transform.right) + transform.position * pushForce;
            GetComponent<Rigidbody>().AddForceAtPosition(f, p); 
        }
	}
}
