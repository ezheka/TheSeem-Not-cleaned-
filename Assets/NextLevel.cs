using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public int idScenes;
    public bool isFinish = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name== "Rabbit Player")
        {
            StartGameBlack.finishBool = isFinish;
            SceneManager.LoadScene(idScenes);            
        }
    }
}
