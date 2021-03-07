using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaccion : MonoBehaviour
{
    private CambiarPreguntas paneles;
    public bool enMesa = false, enMesaCanulas = false, selEst = false, enSignos = false, enCamilla = false;
    public GameObject avisoSig, monitor, VideoMonitor;
    public GameObject aviso1, actividad1, aviso2, actividad2;
    public GameObject avisoEst;
    public GameObject manoEst, manosNorm, puntos;
    public CambioCamara cambio;

    void Start()
    {
        paneles = GetComponent<CambiarPreguntas>();
        cambio = GetComponent<CambioCamara>();
        var videoPlayer = VideoMonitor.gameObject.GetComponent<UnityEngine.Video.VideoPlayer>();
        videoPlayer.url = System.IO.Path.Combine(Application.streamingAssetsPath, "Monitor.mp4");
    }

    void Update()
    {
        switch (paneles.i)
        {
            case 0:
                if (enSignos)
                {
                    monitor.gameObject.SetActive(true);
                    avisoSig.gameObject.SetActive(false);
                }
                else
                {
                    monitor.gameObject.SetActive(false);
                    avisoSig.gameObject.SetActive(true);
                }

                break;
            case 1:
                if (enMesa)
                {
                    actividad1.gameObject.SetActive(true);
                    aviso1.gameObject.SetActive(false);
                }
                else
                {
                    actividad1.gameObject.SetActive(false);
                    aviso1.gameObject.SetActive(true);
                }

                break;
            case 2:
                if (enCamilla)
                {
                    cambio.ponerFace();
                    avisoEst.gameObject.SetActive(false);
                }

                break;
            case 11:
                if (enMesaCanulas)
                {
                    actividad2.gameObject.SetActive(true);
                    aviso2.gameObject.SetActive(false);
                }
                else
                {
                    actividad2.gameObject.SetActive(false);
                    aviso2.gameObject.SetActive(true);
                }
                break;
        }
    }

    public void changeManos(bool est)
    {
        selEst = est;
        manoEst.gameObject.SetActive(est);
        manosNorm.gameObject.SetActive(!est);
        puntos.gameObject.SetActive(est);
    }
}
