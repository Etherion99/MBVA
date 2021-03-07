using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Analytics;


public class AccionesPrincipal : MonoBehaviour
{
    public GameObject HistorialBack, TareasBack, correct, incorrect, salirPanel, punRojo, PunVerde;
    public Camera camFPS, camFin;
    public Canvas canvasFin, canvasPrin;
    public Fin final;

    public void Histo()
    {
        HistorialBack.gameObject.SetActive(true);
    }

    public void HistoBack()
    {
        HistorialBack.gameObject.SetActive(false);
    }

    public void Tarea()
    {
        TareasBack.gameObject.SetActive(true);
    }

    public void TareaBack()
    {
        TareasBack.gameObject.SetActive(false);
    }

    public void terminar()
    {
        SceneManager.LoadScene("Inicio", LoadSceneMode.Single);

        AnalyticsResult result = Analytics.CustomEvent("Finalizaciones");
        Debug.Log("Analytics result: " + result);
    }

    public void salir() {
        SceneManager.LoadScene("Inicio", LoadSceneMode.Single);

        AnalyticsResult result = Analytics.CustomEvent("Abandonos");
        Debug.Log("Analytics result: " + result);
    }

    public void end()
    {
        final.setDatos();
        camFin.enabled = true;
        canvasFin.enabled = true;
        camFPS.enabled = false;
        canvasPrin.enabled = false;
        
        camFin.GetComponent<AudioListener>().enabled = true;
        camFPS.GetComponent<AudioListener>().enabled = false;
    }

    public void ActivarPanSalir()
    {
        salirPanel.gameObject.SetActive(true);
    }

    public void DesPanSalir()
    {
        salirPanel.gameObject.SetActive(false);
    }

    public void Acierto()
    {
        correct.gameObject.SetActive(true);
        PunVerde.gameObject.SetActive(true);

        AnalyticsResult result = Analytics.CustomEvent("Acierto");
        Debug.Log("Analytics result: " + result);
        //System.Threading.Thread.Sleep(3000);
        //correct.gameObject.SetActive(false);
    }

    public void Equivocacion()
    {
        incorrect.gameObject.SetActive(true);
        punRojo.gameObject.SetActive(true);

        AnalyticsResult result = Analytics.CustomEvent("Equivocacion");
        Debug.Log("Analytics result: " + result);
        //System.Threading.Thread.Sleep(3000);
        //incorrect.gameObject.SetActive(false);
    }

    public void DesBotones()
    {
        correct.gameObject.SetActive(false);
        incorrect.gameObject.SetActive(false);
        punRojo.gameObject.SetActive(false);
        PunVerde.gameObject.SetActive(false);
    }
}
