using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPattern : MonoBehaviour
{
    public GameObject mechant;
    public void spawn()
    {
        GameObject shoot;
        shoot = Instantiate(mechant, transform.position, transform.rotation);

    }
}
