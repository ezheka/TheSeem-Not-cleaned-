using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bonusspeed : MonoBehaviour
{
    public PlayerBehaviour _player;

    void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            // было +=10
            _player.Speed += 2f;
        }
    }

}