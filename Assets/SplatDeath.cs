using UnityEngine;
using System.Collections;

public class SplatDeath : MonoBehaviour {
    public int destroyTime;
	// Use this for initialization
	void Start () {

		Destroy (this.gameObject, destroyTime);
    }
	
}
