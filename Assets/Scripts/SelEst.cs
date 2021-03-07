using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class SelEst : MonoBehaviour
{
    public Interaccion controlador;
    public AccionesPrincipal ac;
    public Puntaje puntos;
    public Vida vida;
    public Camera camara;
    void Start()
    {

    }

    void Update()
    {
        /*if (Input.GetMouseButtonDown(0))
        {
            Debug.Log(camara.ScreenToWorldPoint(Input.mousePosition));
        }*/       
    }

    void OnMouseDown()
    {
        if (controlador.selEst == false && transform.name == "Estetoscopio")
        {
            controlador.changeManos(true);
            //System.Threading.Thread.Sleep(3000);
            //correct.gameObject.SetActive(false);
            ac.Acierto();
            puntos.ModificarPuntaje(15);
            AnalyticsResult result = Analytics.CustomEvent("EstBien");
            Debug.Log("Analytics result: " + result);
        }
        else if (controlador.selEst == false)
        {
            puntos.ModificarPuntaje(-10);
            vida.modificar(-15);
            ac.Equivocacion();
            //System.Threading.Thread.Sleep(3000);
            //incorrect.gameObject.SetActive(false);
            AnalyticsResult result = Analytics.CustomEvent("EstMal");
            Debug.Log("Analytics result: " + result);
        }

        Debug.Log(transform.name);
    }
}
