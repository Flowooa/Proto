using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SorciereBehaviour : MonoBehaviour
{
    private SorcierePattern shooter;
    public float spawnspeed;

    private void Start()

    {    
           shooter = GetComponent<SorcierePattern>();
        InvokeRepeating(nameof(Shoot), 0, spawnspeed);      
    }
    private void Shoot()
    {
        shooter.spawn();
    }
}
