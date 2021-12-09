using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShoot1 : MonoBehaviour
{

    public Vector2 direction = new Vector2(-1, 0);
    public float speed = 5;

    public Vector2 Velocity;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 3);  
    }

    // Update is called once per frame
    void Update()
    {
        Velocity = direction * speed; 
    }

    private void FixedUpdate()
    {
        Vector2 pos = transform.position;

        pos += Velocity * Time.fixedDeltaTime;
        transform.position = pos; 
    }



}


