﻿using UnityEngine;
using System.Collections;

public class Launcher : MonoBehaviour {

    public float power;
    public GameObject prefab;
    public GameObject spawnLocation;


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            SpawnPinball();
        }
    }

	void SpawnPinball()
    {
        GameObject pinball = (GameObject)(Instantiate(prefab, spawnLocation.GetComponent<Transform>().position, spawnLocation.GetComponent<Transform>().rotation));
        pinball.GetComponent<Rigidbody>().velocity = transform.forward * power;
    }

    

	}

