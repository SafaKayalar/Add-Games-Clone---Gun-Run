using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {
        float inputX = Input.GetAxisRaw("Horizontal");

        Vector3 velocity = new Vector3(inputX * speed, rb.velocity.y, 0);
        rb.velocity = velocity;
    }
}