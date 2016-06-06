using UnityEngine;
using System.Collections;

public class SlimeMovement : MonoBehaviour
{
    [SerializeField]
    private GameObject splat;
    public Vector2 startingDirection;
    public float speed = 1.5f;
	public int scoreValue;
	public GameController gameController;

    // Use this for initialization
    void Start()
    {
		//Each instance gets a reference to the game controller
		GameObject gameControllerObject = GameObject.FindGameObjectWithTag ("Manager");
		gameController = gameControllerObject.GetComponent<GameController> ();

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
		gameController.AddScore (scoreValue);
    }
}
