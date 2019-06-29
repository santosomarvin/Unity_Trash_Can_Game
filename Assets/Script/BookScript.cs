﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookScript : MonoBehaviour
{
	float strength = 5f;
	public Rigidbody rb;
	int side;

	// Start is called before the first frame update
	void Start()
    {
		rb = GetComponent<Rigidbody>();
		rb.AddForce((transform.forward * Random.Range(0.4f, 1f) + transform.up * Random.Range(0.2f, 0.8f)) * strength, ForceMode.Impulse);
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
