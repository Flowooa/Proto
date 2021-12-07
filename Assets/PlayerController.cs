using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    private PlayerInputAction playerInput;
    private Rigidbody2D rb;
    private Shooter2D shooter;
    private PlayerFire Fire;
    private void Awake()
    {
        Fire = new PlayerFire();
        playerInput = new PlayerInputAction();
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnEnable()
    {
        playerInput.Enable();
        Fire.Enable();
    }
    private void OnDisable()
    {
        playerInput.Disable();
        Fire.Disable();
    }
   /* private void Start()
    {
        GetComponent<PlayerFire>;
    }*/


    private void Shoot()
    {
        shooter.Shoot();
    }


    // Update is called once per frame
    public Transform origine;
    public Transform maximum;  
   /* void Update()
    {
        var rbpos = rb.position;
        if (rbpos.x > maximum.position.x || rbpos.x < origine.position.x)
        {

            rbpos.x = Mathf.Clamp(rbpos.x, origine.position.x ,maximum.position.x);
            rb.MovePosition(rbpos);
        }
        if (rbpos.y > maximum.position.y || rbpos.y < maximum.position.x)
        {
            rbpos.y = Mathf.Clamp(rbpos.y, origine.position.y ,maximum.position.y);
            rb.MovePosition(rbpos);
        }
    }*/
    private void FixedUpdate()
    {
        Vector2 MoveInput = playerInput.Mouvement.Move.ReadValue<Vector2>();
        rb.velocity = MoveInput * speed;


    }
}
