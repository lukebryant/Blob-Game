using UnityEngine;
using System.Collections;

public class SlimeMovement : MonoBehaviour
{
    private Vector3 direction;
    public float speed = 1.5f;

    // Use this for initialization
    void Start()
    {
        direction = (new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f), 0.0f)).normalized;
    }

    // Update is called once per frame
    void Update()
    {


        transform.position += direction * speed * Time.deltaTime;


    }
}
