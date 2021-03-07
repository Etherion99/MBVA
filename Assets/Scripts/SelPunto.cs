using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class SelPunto : MonoBehaviour
{
    public Interaccion controlador;
    public CambiarPreguntas paneles;
    public Puntaje puntos;
    public Vida vida;
    public CambioCamara cambio;
    public Camera camara;

    void Update()
    {
        /*if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = camara.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit, 100.0f))
            {
                Debug.Log(hit.transform.name);
            }
        }*/
    }

    void OnMouseDown()
    {
        Debug.Log(transform.name);
        if (controlador.selEst == true && transform.name == "Punto1")
        {
            controlador.changeManos(false);
            paneles.avanzar();
            puntos.ModificarPuntaje(15);
            cambio.ponerFPS(true);

            AnalyticsResult result = Analytics.CustomEvent("EstPuntoBien");
            Debug.Log("Analytics result: " + result);
        }
        else if (controlador.selEst == true)
        {
            puntos.ModificarPuntaje(-10);
            vida.modificar(-15);

            AnalyticsResult result = Analytics.CustomEvent("EstPuntoMal");
            Debug.Log("Analytics result: " + result);
        }

        Debug.Log(transform.name);
    }
}
