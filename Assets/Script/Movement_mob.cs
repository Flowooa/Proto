using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Movement_mob : MonoBehaviour

{
    public float moveSpeed = 5;
  

    private void FixedUpdate()
    {
        Vector2 pos = transform.position;

        pos.x -= moveSpeed * Time.fixedDeltaTime;

        if (pos.x < -10)
        {
            Destroy(gameObject);
        }
        transform.position = pos;  

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}

