﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionPlateforme : MonoBehaviour
{

    public float vitesse;

    public Vector3 posXMax;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position - (Vector3.left * (vitesse * Time.deltaTime));
        if (transform.position.x <= posXMax.x)
        {
            Destroy(gameObject);
        }
    }
}
