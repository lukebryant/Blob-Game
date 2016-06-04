﻿using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	private Vector3 target;
    [SerializeField]
    float speed = 1.5f;
    [SerializeField]
    int id;
    private bool active;
    private Rigidbody2D rigidBody;

    // Use this for initialization
    void Start () {
		target = transform.position;
        //rigidBody.GetComponent<Rigidbody2D>();
        //rigidBody.detectCollisions = false;
        if (id == 0) active = true;
        else active = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("0"))
        {
            if (id == 0) active = true;
            else active = false;
        }
        if (Input.GetKey("1"))
        {
            if (id == 1) active = true;
            else active = false;
        }
        if (!active) return;
        if (Input.GetMouseButtonDown(0))
        {
            //rigidBody.detectCollisions = true;
        }
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		var target = new Vector3(mousePos.x,mousePos.y,transform.position.z);

        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

        if (10 < Vector3.Magnitude(transform.position - mousePos))
        {
            Quaternion rot = Quaternion.LookRotation(transform.position - mousePos, Vector3.forward);
            transform.rotation = rot;
            transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z);
        }
    }
}