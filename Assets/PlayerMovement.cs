﻿using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
    [SerializeField]
    float speed = 1.5f;
    [SerializeField]
    int id;
    [SerializeField]
    private GameObject sword;

    private static float swingSpeed = 150f;

    private static float swordDistance = 0.4f;
    private static Vector3 startingSwordAngle = new Vector3(0, 0, -70.0f);

    private Vector3 target;
    private bool active;
    private PolygonCollider2D swordCollider;
    private Vector3 swordAngle;
    private bool swinging = false;
    
    // Use this for initialization
    void Start () {
		target = transform.position;
        swordCollider = GetComponentInChildren<PolygonCollider2D>();
        swordCollider.isTrigger = true;
        swordAngle = startingSwordAngle;
        RotateSword(swordAngle);
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
        if (!swinging) if (Input.GetMouseButtonDown(0)) swinging = true;
        if (swinging)
        {
            RotateSword(swordAngle);
            swordAngle.z += Time.deltaTime * swingSpeed;
            if (swordAngle.z >= 70) {
                swordAngle = startingSwordAngle;
                swinging = false;
                RotateSword(swordAngle);
            }
            return;
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

    //rotates the sword to "angle" around the player, while maintaining constant distance "swordDistance"
    void RotateSword(Vector3 angle)
    {
        Quaternion rot = Quaternion.AngleAxis(angle.z, Vector3.forward);
        sword.transform.localPosition = swordDistance * (rot * Vector3.up);
        sword.transform.localRotation = rot;
    }
}