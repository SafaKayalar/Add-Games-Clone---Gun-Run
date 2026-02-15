using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private float cooldown;
    private float fireTimer;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        fireTimer += Time.deltaTime;

        if (fireTimer >= cooldown)
        {
            Vector3 spawnPos = transform.position + transform.forward * 0.7f;
            Instantiate(bullet, spawnPos, transform.rotation);

            fireTimer = 0f;
        }

    }
}
