using System;
using UnityEngine;

public class Move2D : MonoBehaviour
{
    public float speed;

    [HideInInspector] public Vector2 direction;

    private Rigidbody2D rb2D;
    public Transform origine;
    public Transform maximum;

    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
       Move();
    }

    private void Move()
    {
        rb2D.velocity = direction.normalized * speed;
    }
}
