using UnityEngine;
using System.Collections;

public class SlimeSpawn : MonoBehaviour
{
    public GameObject[] enemies;

    public int total;

    private Vector3 spawnPoint;

	void Update ()
    {
        //find the amount of enemies in the scene
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        total = enemies.Length;

	}
}
