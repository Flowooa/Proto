using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServeurBehaviour : MonoBehaviour
{
    private ServeurPattern shooter;

    // Start is called before the first frame update
    private void Start()
    {
        shooter = GetComponent<ServeurPattern>();
        InvokeRepeating(nameof(Shoot), 0, 0.5f);
    }

    private void Shoot()
    {
        shooter.pentakill();
    }
}
