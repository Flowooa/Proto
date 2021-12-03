using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    private PlayerInputAction playerInput;
    private Rigidbody2D rb;
    private void Awake()
    {
        playerInput = new PlayerInputAction();
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnEnable()
    {
        playerInput.Enable();
    }
    private void OnDisable()
    {
        playerInput.Disable();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        Vector2 MoveInput = playerInput.Mouvement.Move.ReadValue<Vector2>();
        rb.velocity = MoveInput * speed;

    }
}
