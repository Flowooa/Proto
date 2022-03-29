using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun_Shoot1 : MonoBehaviour
{
    public BulletShoot1 bullet;


    public void Shoot1()
    {
        GameObject go = Instantiate(bullet.gameObject, transform.position, Quaternion.identity);
    }


}
