using UnityEngine;
using System.Collections;

public class SlimeMovement : MonoBehaviour
{
    [SerializeField]
    private GameObject splat;
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

    public void Die()
    {
        GameObject newSplat = (GameObject)Instantiate(splat);
        newSplat.transform.position = this.transform.position;
		Destroy (gameObject);
    }
}
