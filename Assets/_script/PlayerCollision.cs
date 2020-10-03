using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{


        private void OnCollisionEnter(Collision collision)
    {
       
        if (collision.gameObject.tag == "door")
        {
           SceneManager.LoadScene("SceneMainMenu");
        }

       else if (collision.gameObject.tag == "door1")
        {
           SceneManager.LoadScene("SceneStage2");
        }
    }

    void Update()
    {
        
    }
    
}
