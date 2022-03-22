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
    bool letsgo = false;
    
   

    // Start is called before the first frame update
    void Start()
    {
        Ult = transform.GetComponentsInChildren<Ult_Shoot>(); 
    }


    // Update is called once per frame
    void Update()
    {  
        shoot = Input.GetKeyDown(KeyCode.DownArrow);
        if (Time.time > lastShoot + rate)
        {
            letsgo = true;
            if (shoot)
            {
                shoot = false;
               
                foreach (Ult_Shoot gun in Ult)
                {
                    gun.UltShoot();
                }
            }
            lastShoot = Time.time;
        }
        
        
    }

}
