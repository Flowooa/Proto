using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Unity.Mathematics;

public class Player2scrip : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject playerSolo, player1, player2;

    private void Start()
    {
        if (PlayerInputManager.instance.playerCount == 1)
        {
            Instantiate(playerSolo, transform);
        }
        else
        {
            var solo = FindObjectOfType<PlayerSolo>().transform;
            var soloPosition = solo.position;
            var soloParent = solo.parent;
            Destroy(solo.gameObject);
            Instantiate(player1, soloPosition, quaternion.identity, soloParent);
            Instantiate(player2, transform);
        }

    }
}