using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.SceneManagement;

public class Trigger : MonoBehaviour
{

   public int y = 0;
    void Start()
    {
       
    }
    void OnTriggerEnter(Collider x)
    {
        if ( x.gameObject.tag=="Levelup")
        {
            y++;
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }
    

    void Update()
    {
        if (y >2)
        {
            
            if (Input.GetKeyUp(KeyCode.Keypad0))
            {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        }
    }
}
