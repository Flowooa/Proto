using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class spawnerbehaviout : MonoBehaviour
{
    private SpawnPattern shooter;
    public float spawnspeed;
    private bool solo = true;

    private void Start()
    
    {
        if (solo == true)
        shooter = GetComponent<SpawnPattern>();
        InvokeRepeating(nameof(Shoot), 0, spawnspeed);
        solo = false;
    }

    private void OnDestroy()
    {
        solo = true;
    }

    private void Shoot()
    {
        shooter.spawn();
    }

}
