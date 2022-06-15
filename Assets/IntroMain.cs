using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class IntroMain : MonoBehaviour
{
    
  public void GoNext(InputAction.CallbackContext context) 
  {
        SceneManager.LoadScene("Menu strat");
  }
    
}
