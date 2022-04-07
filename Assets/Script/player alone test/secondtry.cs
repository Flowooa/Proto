using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class secondtry : MonoBehaviour
{
    public float cadence;
    private float lastShoot;

    Gun_Shoot[] guns;
    Gun_Shoot1[] guns1;

    bool shoot;
    bool shoot1;

    bool shootpressed;
    bool shootpressed1;

    // Start is called before the first frame update
    void Start()
    {
        guns = transform.GetComponentsInChildren<Gun_Shoot>();
        guns1 = transform.GetComponentsInChildren<Gun_Shoot1>();
    }

    public void TirDroite(InputAction.CallbackContext context)
    {
        if (context.performed)
            StartCoroutine(shootCouroutine());
        if (context.canceled)
            shootpressed = false;

        if (!context.performed)
            return;

        if (Time.time > lastShoot + cadence)
        {
            shoot = false;
            foreach (Gun_Shoot gun in guns)
            {
                gun.Shoot();
            }
        }
    }
    public void TirGauche(InputAction.CallbackContext context)
    {
        if (context.performed)
            StartCoroutine(shoot1Couroutine());
        if (context.canceled)
            shootpressed1 = false;
        if (!context.performed)
            return;

        if (Time.time > lastShoot + cadence)
        {
            shoot1 = false;
            foreach (Gun_Shoot1 gun in guns1)
            {
                gun.Shoot1();
            }
        }
    }

    private IEnumerator shoot1Couroutine()
    {
        shootpressed1 = true;
        while (shootpressed1)
        {
            guns1[0].Shoot1();
            yield return new WaitForSeconds(0.2f);
        }
    }
    private IEnumerator shootCouroutine()
    {
        shootpressed = true;
        while (shootpressed)
        {
            guns[0].Shoot();
            yield return new WaitForSeconds(0.2f);
        }
    }
}


