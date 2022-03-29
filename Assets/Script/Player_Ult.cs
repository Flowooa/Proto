using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Player_Ult : MonoBehaviour
{
    Ult_Shoot[] Ult; 
    bool shoot;
    public float rate;
    private float lastShoot;
    bool blink;

    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponentInParent<Animator>();
        Ult = transform.GetComponentsInChildren<Ult_Shoot>(); 
    }


    // Update is called once per frame
    void Update()
    {
        shoot = Input.GetKeyDown(KeyCode.DownArrow);

        if (Time.time > lastShoot + rate)
        {
            if (!blink)
            {
                animator.SetTrigger("blink");
                

                if (shoot)
                {
                    shoot = false;
               
                    animator.SetTrigger("not");

                    foreach (Ult_Shoot gun in Ult)
                    {
                        gun.UltShoot();
                    }
                }

            }
            lastShoot = Time.time;

        }
    }
}
