﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkTestInput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) {
            this.GetComponent<Animator>().Play("enemy_Run");
        }
    }
}
