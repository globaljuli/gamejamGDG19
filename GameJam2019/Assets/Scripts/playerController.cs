﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float velocity = 7f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * velocity * Time.deltaTime;
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * velocity * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * velocity * Time.deltaTime;
        }

        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * velocity * Time.deltaTime;
        }
    }
}