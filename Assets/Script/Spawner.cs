using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    [SerializeField] private float time = 1.5f;
    public GameObject mechant;
    private bool seul = true;
    


    // Start is called before the first frame update
    void Start()
    {
        if(seul == true)
        {
            SpawnEnnemy();
            mechant = GetComponent<GameObject>();
            Debug.Log("spaxn");
            seul = false;
        }
    }
    IEnumerator SpawnEnnemy()
    {
        yield return new WaitForSeconds(time);

    }
}
