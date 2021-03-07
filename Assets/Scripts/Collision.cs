using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public Interaccion controlador;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.name == "mesa")
        {
            controlador.enMesa = true;
        }
        else if (other.transform.name == "mesa canulas")
        {
            controlador.enMesaCanulas = true;
        }
        else if (other.transform.name == "monitor")
        {
            controlador.enSignos = true;
        }
        else if (other.transform.name == "camilla")
        {
            controlador.enCamilla = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.transform.name == "mesa")
        {
            controlador.enMesa = false;
        }
        else if (other.transform.name == "mesa canulas")
        {
            controlador.enMesaCanulas = false;

        }
        else if (other.transform.name == "monitor")
        {
            controlador.enSignos = false;

        }
        else if (other.transform.name == "camilla")
        {
            controlador.enCamilla = false;
        }

    }

}
