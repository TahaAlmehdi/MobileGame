﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death_touch : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        print("Death ");
    }
}
