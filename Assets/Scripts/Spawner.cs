using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private float spawnTimer;
    public float spawnCooldown;
    [SerializeField] private GameObject enemy;


    void Start()
    {
        spawnTimer = spawnCooldown;
    }

    // Update is called once per frame
    void Update()
    {    
        spawnTimer += Time.deltaTime;
        if (spawnTimer >= spawnCooldown)
        {
            Vector3 spawnPos = new Vector3(Random.Range(-4, 4), 1.5f, 20);
            Instantiate(enemy, spawnPos, transform.rotation);

            spawnTimer = 0f;
        }
    }
}





