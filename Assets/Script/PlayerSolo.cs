using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerSolo : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        GetComponentInParent<PlayerInput>().SwitchCurrentActionMap("PlayerSolo");
    }
}