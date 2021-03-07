using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traccion : MonoBehaviour
{
    public CambioCamara cambio;
    public AnimarPersonaje anim;
    public GameObject panel, avanzar;
    void Start()
    {
        cambio.ponerTraccion();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            cambio.ponerFPS();
        }
    }

    public void animar()
    {
        avanzar.gameObject.SetActive(true);
        panel.gameObject.SetActive(false);
        anim.openJaw();
    }
}
