using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Inicio : MonoBehaviour
{
    public Camera camara1, camara2;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void info()
    {
        camara2.enabled = true;
        camara1.enabled = false;

        camara2.GetComponent<AudioListener>().enabled = true;
        camara1.GetComponent<AudioListener>().enabled = false;
    }

    public void info1()
    {
        camara1.enabled = true;
        camara2.enabled = false;

        camara1.GetComponent<AudioListener>().enabled = true;
        camara2.GetComponent<AudioListener>().enabled = false;
    }
}
