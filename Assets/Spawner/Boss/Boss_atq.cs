using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_atq : MonoBehaviour
{

    public Transform enemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void SpawnEnemy()
    {
        Instantiate(enemy, transform.position, transform.rotation);
    }


}
