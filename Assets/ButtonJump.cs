using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonJump : MonoBehaviour
{
    public GameObject player;
    private PlayerBehaviour main;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        main = player.GetComponent<PlayerBehaviour>();
    }

    private void OnMouseDown()
    {
        main.Jump();
    }
}
