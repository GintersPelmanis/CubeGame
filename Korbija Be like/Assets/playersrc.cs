﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playersrc : MonoBehaviour
{
    public GameObject bulletPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        { 
            GameObject bulletObject = Instantiate(bulletPrefab);
            bulletObject.transform.position = transform.position + transform.forward;
            bulletObject.transform.forward = transform.forward;
        }
        
    }
}
