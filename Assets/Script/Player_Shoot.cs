using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player_Shoot : MonoBehaviour
{
    public float cadence;
    private float lastShoot;

    Gun_Shoot[] guns;
    Gun_Shoot1[] guns1;

    bool shoot;
    bool shoot1;

    // Start is called before the first frame update
    void Start()
    {
        guns = transform.GetComponentsInChildren<Gun_Shoot>();
        guns1 = transform.GetComponentsInChildren<Gun_Shoot1>();
    }
    
    public void TirDroite (InputAction.CallbackContext context)
    {
        if (Time.time > lastShoot + cadence)
        {
            shoot = false;
            foreach (Gun_Shoot gun in guns)
            {
                gun.Shoot();
            }
        }
    }
    public void TirGauche (InputAction.CallbackContext context)
    {
        if (shoot1)
        {
            shoot1 = false;
            foreach (Gun_Shoot1 gun in guns1)
            {
                gun.Shoot1();
            }
        }
    }

  
}
