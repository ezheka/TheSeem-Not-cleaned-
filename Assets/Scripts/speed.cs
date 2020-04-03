using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speed : MonoBehaviour
{
    public GameObject player;
    private PlayerBehaviour playerBehaviour;
    public float AccelerationTime = 2f;
    public float PitchAccelerationTime;
    public float TargetSpeed;
    private bool _acceleration = false;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerBehaviour = player.GetComponent<PlayerBehaviour>();
    }

    private void Update()
    {
        //if (_acceleration)
        //{
        //    playerBehaviour.Speed = Mathf.Lerp(playerBehaviour.Speed, TargetSpeed, AccelerationTime * Time.deltaTime);
        //    playerBehaviour.ASourсe.pitch = Mathf.Lerp(playerBehaviour.ASourсe.pitch, 1f, PitchAccelerationTime * Time.deltaTime);
        //}
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            //_acceleration = true;
            playerBehaviour.Speed += 2;
        }
    }

}