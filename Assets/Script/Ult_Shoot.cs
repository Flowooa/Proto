using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ult_Shoot : MonoBehaviour
{
    public GameObject Ult;


    public void UltShoot()
    {
        GameObject go = Instantiate(Ult.gameObject, transform.position, Quaternion.identity);
    }

}
