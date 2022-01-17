using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemieFollower : MonoBehaviour
{
    private Rigidbody2D rb;
      private Transform player;
    public float moveSpeed = 5f;
    private Vector2 movement;

    void Start()
    {
        
        rb = this.GetComponent<Rigidbody2D>();
        var p = GameObject.FindWithTag("Player");
        player = p.transform;
    }
 
    void Update()
    {
        Vector3 direction = player.position - transform.position;
        Debug.Log(direction);
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
        direction.Normalize();
        movement = direction;
    }

    private void FixedUpdate()
    {
        moveCharacter(movement);
    }

    void moveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }



}
