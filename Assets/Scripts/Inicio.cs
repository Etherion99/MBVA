using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Analytics;

public class Inicio : MonoBehaviour
{
    public Camera camara1, camara2, camara3;
    public Canvas canvas1, canvas2, canvas3;
    public GameObject SelDificil, SelMedio, SelFacil, SelExperto, tutorial1, tutorial2, usuario, contexto, videoCont;

    public void info()
    {
        tutorial2.gameObject.SetActive(false);
        tutorial1.gameObject.SetActive(true);

        camara2.enabled = true;
        canvas2.enabled = true;
        camara1.enabled = false;
        canvas1.enabled = false;

        camara2.GetComponent<AudioListener>().enabled = true;
        camara1.GetComponent<AudioListener>().enabled = false;
    }

    public void tutorial()
    {
        tutorial1.gameObject.SetActive(false);
        tutorial2.gameObject.SetActive(true);
    }

    public void Contexto()
    {
        if (GameData.tiempoJuego != 0)
        {
            var videoPlayer = videoCont.gameObject.GetComponent<UnityEngine.Video.VideoPlayer>();
            usuario.gameObject.SetActive(false);
            contexto.gameObject.SetActive(true);
            videoPlayer.url = System.IO.Path.Combine(Application.streamingAssetsPath, "videoInicio.mp4");
            videoPlayer.Play();
        }
    }

    public void next()
    {
        tutorial2.gameObject.SetActive(false);
        tutorial1.gameObject.SetActive(false);

        camara3.enabled = true;
        canvas3.enabled = true;
        camara2.enabled = false;
        canvas2.enabled = false;

        camara3.GetComponent<AudioListener>().enabled = true;
        camara2.GetComponent<AudioListener>().enabled = false;

        usuario.gameObject.SetActive(true);
        contexto.gameObject.SetActive(false);
    }
    public void SetTiempoFacil()
    {
        SelFacil.gameObject.SetActive(true);
        SelMedio.gameObject.SetActive(false);
        SelDificil.gameObject.SetActive(false);
        SelExperto.gameObject.SetActive(false);

        AnalyticsResult result = Analytics.CustomEvent("DifFacil");
        Debug.Log("Analytics result: " + result);
    }

    public void SetTiempoMedio()
    {
        SelFacil.gameObject.SetActive(false);
        SelMedio.gameObject.SetActive(true);
        SelDificil.gameObject.SetActive(false);
        SelExperto.gameObject.SetActive(false);

        AnalyticsResult result = Analytics.CustomEvent("DifMedio");
        Debug.Log("Analytics result: " + result);
    }

    public void SetTiempoDificil()
    {
        SelFacil.gameObject.SetActive(false);
        SelMedio.gameObject.SetActive(false);
        SelDificil.gameObject.SetActive(true);
        SelExperto.gameObject.SetActive(false);

        AnalyticsResult result = Analytics.CustomEvent("DifDificil");
        Debug.Log("Analytics result: " + result);
    }

    public void SetTiempoExperto()
    {
        SelFacil.gameObject.SetActive(false);
        SelMedio.gameObject.SetActive(false);
        SelDificil.gameObject.SetActive(false);
        SelExperto.gameObject.SetActive(true);

        AnalyticsResult result = Analytics.CustomEvent("DifExperto");
        Debug.Log("Analytics result: " + result);
    }

    public void inicio()
    {
        
        SceneManager.LoadScene("Principal", LoadSceneMode.Single);

        usuario.gameObject.SetActive(false);
        contexto.gameObject.SetActive(false);

        AnalyticsResult result = Analytics.CustomEvent("Jugar");
        Debug.Log("Analytics result: " + result);
          
    }

    public void fin() 
    {
        Application.Quit();
    }
}
