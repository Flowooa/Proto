using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    bool E1;
    bool E2;
    bool E3;
    bool E4;
    bool E5;
    bool E6;

    private void Update()
    {
     E1 = Input.GetKeyDown(KeyCode.Alpha1);

        if (E1)
        {
            SceneManager.LoadScene("E1");
        }

    
     E2 = Input.GetKeyDown(KeyCode.Alpha2);

        if (E2)
        {
            SceneManager.LoadScene("E2");
        }
       
     E3 = Input.GetKeyDown(KeyCode.Alpha3);

        if (E3)
        {
            SceneManager.LoadScene("E3");
        }

     E4 = Input.GetKeyDown(KeyCode.Alpha4);

        if (E4)
        {
            SceneManager.LoadScene("E4");
        }



     E5 = Input.GetKeyDown(KeyCode.Alpha5);

        if (E5)
        {
            SceneManager.LoadScene("E5");
        }

     E6 = Input.GetKeyDown(KeyCode.Alpha6);

        if (E6)
        {
            SceneManager.LoadScene("E6");
        }

    }
}

