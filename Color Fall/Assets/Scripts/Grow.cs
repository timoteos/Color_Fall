﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grow : MonoBehaviour
{

    public bool grow = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (grow)
        {
            this.transform.localScale += new Vector3(5f, 10f, 0) * Time.deltaTime;
        }
    }
}
