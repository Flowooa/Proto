using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun_Shoot1 : MonoBehaviour
{
    public BulletShoot1 bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shoot1()
    {
        GameObject go = Instantiate(bullet.gameObject, transform.position, Quaternion.identity);
    }


}
