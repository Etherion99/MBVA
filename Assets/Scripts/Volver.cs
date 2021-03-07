using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Volver : MonoBehaviour
{
    public CambioCamara cambio;
    void Start()
    {
        cambio.ponerFPS();
    }
}
