using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class Canula : MonoBehaviour
{
    public Interaccion controlador;
    public AccionesPrincipal ac;
    public Puntaje puntos;
    public Vida vida;
    public int canula = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void seleccionar()
    {
        if (canula == 2)
        {
            ac.Acierto();
            puntos.ModificarPuntaje(20);
            AnalyticsResult result = Analytics.CustomEvent("CanulaBien");
            Debug.Log("Analytics result: " + result);
        }
        else if (controlador.selEst == false)
        {
            ac.Equivocacion();
            puntos.ModificarPuntaje(-10);
            vida.modificar(-15);
            AnalyticsResult result = Analytics.CustomEvent("CanulaMal");
            Debug.Log("Analytics result: " + result);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
