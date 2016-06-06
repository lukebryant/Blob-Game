using UnityEngine;
using System.Collections;

public class SlimeMovement : MonoBehaviour
{
    public Vector2 startingDirection;
    public float speed = 1.5f;

    // Use this for initialization
    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(startingDirection);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
