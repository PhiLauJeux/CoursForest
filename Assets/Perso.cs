using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perso : MonoBehaviour {
	public float maxSpeed = 1f;
	public float JumpForce = 700f;
	public Rigidbody2D rdb2d;
	// Use this for initialization
	void Start () {
		rdb2d = gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)){
			rdb2d.AddForce (new Vector2 (0, JumpForce));
		}
	}

	void FixedUpdate () {
		float move = Input.GetAxis ("Horizontal");
		rdb2d.velocity = new Vector2 (move * maxSpeed, rdb2d.velocity.y);
	}
}
