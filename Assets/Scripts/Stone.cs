﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour {

    public GameObject explosion;
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.y < -30.0f)
        {
            Destroy(gameObject);
        }
	}

    private void OnMouseDown()
    {
        // Quaternion.identity hace que el giro sea el mismo
        Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(gameObject);
        GameManager.stonesDestroyed++;
    }
}
