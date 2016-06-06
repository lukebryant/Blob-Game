using UnityEngine;
using System.Collections;

public class SwordCollision : MonoBehaviour {
    private PlayerMovement playerMovement;
	// Use this for initialization
	void Start () {
        playerMovement = this.gameObject.GetComponentInParent<PlayerMovement>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(playerMovement.isSwinging()) Destroy(other.gameObject);
    }
}
