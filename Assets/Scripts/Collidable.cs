﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collidable : MonoBehaviour {
	public GameManager manager;
	public float moveSpeed = 20f;
	public float timeAmount = 1.5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(0, 0, -moveSpeed * Time.deltaTime);
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			manager.AdjustTime(timeAmount);
			Destroy(gameObject);
		}
	}
}
