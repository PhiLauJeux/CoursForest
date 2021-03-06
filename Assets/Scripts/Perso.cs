﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Perso : MonoBehaviour {
	public float maxSpeed = 1f;
	public float JumpForce = 700f;
	public float scoreDistance = 0f;
	public Rigidbody2D rdb2d;
	public bool surPlancher = true;
	public Text Pointage;
	// Use this for initialization
	void Start () {
		rdb2d = gameObject.GetComponent<Rigidbody2D>();
		InvokeRepeating("TimerSecondes", 1, 1);
	}
	
	// Update is called once per frame
	void Update () {
		if (surPlancher == true) {
			if (Input.GetKeyDown (KeyCode.Space)) {
				rdb2d.AddForce (new Vector2 (0, JumpForce));
			}
		}
		Pointage.text = scoreDistance + "";
	}

	void FixedUpdate () {
        Debug.DrawLine(transform.position - new Vector3(0, 0.7f, 0), transform.position - new Vector3(0, 0.9f, 0), Color.red);
		float move = Input.GetAxis ("Horizontal");
		rdb2d.velocity = new Vector2 (move * maxSpeed, rdb2d.velocity.y);

        RaycastHit2D hit = Physics2D.Raycast(transform.position - new Vector3(0, 0.7f, 0), -Vector2.up, 0.6f);

        if (hit.collider != null)
        {
            if (hit.collider.tag == "plancher")
            {
                surPlancher = true;
            }
            else
            {
                surPlancher = false;
            }
        }
        else
        {
            surPlancher = false;
        }
	}
	void TimerSecondes()
	{
		scoreDistance += 1;
	}
	
}
