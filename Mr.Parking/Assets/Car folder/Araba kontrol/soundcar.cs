using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class soundcar : MonoBehaviour
{
    public AudioClip Musicses;
    public AudioSource Muzik;
    
    
    // Start is called before the first frame update
    void Start()
    {
        Muzik.clip = Musicses;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            
            Muzik.Play();
        }
        if (Input.GetKeyUp(KeyCode.H))
        {
            Muzik.Stop();
        }

    }
}
