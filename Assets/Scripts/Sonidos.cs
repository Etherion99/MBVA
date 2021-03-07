using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonidos : MonoBehaviour
{
    public AudioSource respiracion, conciencia;

    public void playRespiracion()
    {
        respiracion.Play();
    }

    public void playConciencia()
    {
        conciencia.Play();
    }
}
