﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class risingLava : MonoBehaviour
    
{
    public float f1_MovementSpeed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, f1_MovementSpeed, 0);
    }
}
