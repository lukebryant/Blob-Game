using UnityEngine;
using System.Collections;

public class SlimeSpawn : MonoBehaviour
{
    public GameObject[] enemies;

    public GameObject Green_slime;

    public int total;

    public int spawntotal;

    private Vector3 spawnPoint;

	void Update ()
    {
        //find the amount of enemies in the scene
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        total = enemies.Length;
        
        if (total < spawntotal)
        {
            spawnEnemy();
        }
	}
    void spawnEnemy ()
    {
        float z = Random.Range(0.0f, 4.0f);
        if(z<=1)
        {
            Vector3 pos = new Vector3(Random.Range(0.0f, 1.0f), -0.1f, 10);
            pos = Camera.main.ViewportToWorldPoint(pos);
            Instantiate(Green_slime, pos, Quaternion.identity);
     
        }
        if(z<=2)
        {
            Vector3 pos = new Vector3(Random.Range(0.0f, 1.0f), 1.1f, 10);
            pos = Camera.main.ViewportToWorldPoint(pos);
            Instantiate(Green_slime, pos, Quaternion.identity);
        }
        if (z <= 3)
        {
            Vector3 pos = new Vector3(1.1f, Random.Range(0.0f, 1.0f), 10);
            pos = Camera.main.ViewportToWorldPoint(pos);
            Instantiate(Green_slime, pos, Quaternion.identity);
        }
        if(z<= 4)
        {
            Vector3 pos = new Vector3(-0.1f, Random.Range(0.0f, 1.0f), 10);
            pos = Camera.main.ViewportToWorldPoint(pos);
            Instantiate(Green_slime, pos, Quaternion.identity);
        }
    }
}
