using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun_Shoot : MonoBehaviour
{
    public BulletShoot bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shoot()
    {
        GameObject go = Instantiate(bullet.gameObject, transform.position, Quaternion.identity);
    }


}
