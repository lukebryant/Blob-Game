using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	private Vector3 target;
	public float speed = 1.5f;

	// Use this for initialization
	void Start () {
		target = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        
		
		var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		target = new Vector3(mousePos.x,mousePos.y,transform.position.z);

       
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
      
       
        

        if (10 < Vector3.Magnitude(transform.position - mousePos))
        {
            Quaternion rot = Quaternion.LookRotation(transform.position - mousePos, Vector3.forward);
            transform.rotation = rot;
            transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z);
        }




    }
}
