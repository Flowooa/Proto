using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    private Rigidbody2D rb;
    private Vector2 MoveInput;
  
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rb.velocity = MoveInput * speed;
    }
     public void OnDeplacement(InputValue value)
    {
        MoveInput = value.Get<Vector2>();
    }

    

}
