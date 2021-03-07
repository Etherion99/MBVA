using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boca : MonoBehaviour
{
    public CambioCamara cambio;
    void Start()
    {
        cambio.ponerLado();
    }
}
