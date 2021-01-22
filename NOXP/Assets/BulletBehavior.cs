﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    public float bulletSpeed;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody ourRigidbody = GetComponent<Rigidbody>();
        ourRigidbody.velocity = transform.forward * bulletSpeed;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
