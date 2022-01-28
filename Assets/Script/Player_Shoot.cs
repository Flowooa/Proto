using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Shoot : MonoBehaviour
{

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
    

    // Update is called once per frame
    void Update()
    {


        shoot1 = Input.GetKeyDown(KeyCode.LeftArrow);
        shoot = Input.GetKeyDown(KeyCode.RightArrow);
        if (shoot)
        {
            shoot = false;
            foreach (Gun_Shoot gun in guns)
            {
                gun.Shoot();
            }
        }

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
