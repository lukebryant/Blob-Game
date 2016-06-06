using UnityEngine;
using System.Collections;

public class SlimeSpawn : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject greenSlime;
    public int total;
    public int spawnTotal;
    public float spawnInterval;
    public float startingForce;
    private Vector3 spawnPoint;
    private float timeSinceLastSpawn = 0;
    private float minAngle = 40.0f; //minimum angle from the starting side that slimes' initial directions can be at

	void Update ()
    {
        //find the amount of enemies in the scene
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        total = enemies.Length;
        timeSinceLastSpawn += Time.deltaTime;
        if (timeSinceLastSpawn >= spawnInterval && total < spawnTotal)
        {
            spawnEnemy();
            timeSinceLastSpawn = 0;
        }
	}
    void spawnEnemy ()
    {
        GameObject slime = (GameObject)Instantiate(greenSlime, Camera.main.ViewportToWorldPoint(new Vector3(10,10,10)), Quaternion.identity);
        Vector3 pos;
        int z = Random.Range(0, 4);
        float angle = 0;
        switch (z)
        {
            case 0:     //below
                slime.transform.position = Camera.main.ViewportToWorldPoint(new Vector3(Random.Range(0.0f, 1.0f), -0.1f, 10));
                angle = Random.Range(0.0f + minAngle, 180.0f - minAngle);
                break;
            case 1:     //above
                slime.transform.position = Camera.main.ViewportToWorldPoint(new Vector3(Random.Range(0.0f, 1.0f), 1.1f, 10));
                angle = Random.Range(180.0f + minAngle, 360.0f - minAngle);
                break;
            case 2:     //right
                slime.transform.position = Camera.main.ViewportToWorldPoint(new Vector3(1.1f, Random.Range(0.0f, 1.0f), 10));
                angle = Random.Range(90.0f + minAngle, 270.0f - minAngle);
                break;
            case 3:     //left
                slime.transform.position = Camera.main.ViewportToWorldPoint(new Vector3(-0.1f, Random.Range(0.0f, 1.0f), 10));
                angle = Random.Range(-90.0f + minAngle, 90.0f - minAngle);
                break;
        }
        Quaternion rot = Quaternion.AngleAxis(angle, Vector3.forward);
        slime.GetComponent<SlimeMovement>().startingDirection = startingForce * (rot * Vector2.right);
    }
}
