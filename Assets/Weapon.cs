﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform firepoint;
    public GameObject shotPrefab;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            Shoot();
        }
    }

    void Shoot(){
        Instantiate(shotPrefab, firepoint.position, firepoint.rotation);
    }
}
