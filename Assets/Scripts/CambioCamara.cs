using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioCamara : MonoBehaviour
{
    public Camera camaraFPS, camaraFace, camaraLado, camaraT;
    public Canvas principal;
    public Movimiento mov;
    public Vector3 estPos, estEul;
    public Camara cam;
    public GameObject copia;

    public void ponerFPS(bool rest = false)
    {
        camaraFPS.enabled = true;
        camaraFace.enabled = false;
        camaraLado.enabled = false;
        camaraT.enabled = false;

        camaraFPS.GetComponent<AudioListener>().enabled = true;
        camaraFace.GetComponent<AudioListener>().enabled = false;
        camaraLado.GetComponent<AudioListener>().enabled = false;
        camaraT.GetComponent<AudioListener>().enabled = false;
        principal.worldCamera = camaraFPS;

        if (rest)
        {
            mov.fijar = false;
            /*cam.manos.transform.position = estPos;
            cam.manos.transform.eulerAngles = estEul;*/
            copia.gameObject.SetActive(false);
            cam.manos.gameObject.SetActive(true);
        }
    }

    public void ponerFace()
    {
        camaraFPS.enabled = false;
        camaraFace.enabled = true;
        camaraLado.enabled = false;
        camaraT.enabled = false;

        camaraFPS.GetComponent<AudioListener>().enabled = false;
        camaraFace.GetComponent<AudioListener>().enabled = true;
        camaraLado.GetComponent<AudioListener>().enabled = false;
        camaraT.GetComponent<AudioListener>().enabled = false;
        principal.worldCamera = camaraFace;

        estPos = cam.manos.transform.position;
        estEul = cam.manos.transform.eulerAngles;

        /*cam.manos.transform.position = new Vector3(2.7f, 0.0f, 2.5f);
        cam.manos.transform.eulerAngles = new Vector3(18.1f, 40.8f, 8.2f);*/

        copia.gameObject.SetActive(true);
        cam.manos.gameObject.SetActive(false);

        mov.fijar = true;
    }

    public void ponerLado()
    {
        camaraFPS.enabled = false;
        camaraFace.enabled = false;
        camaraLado.enabled = true;
        camaraT.enabled = false;

        camaraFPS.GetComponent<AudioListener>().enabled = false;
        camaraFace.GetComponent<AudioListener>().enabled = false;
        camaraLado.GetComponent<AudioListener>().enabled = true;
        camaraT.GetComponent<AudioListener>().enabled = false;
        principal.worldCamera = camaraLado;
    }

    public void ponerTraccion()
    {
        camaraFPS.enabled = false;
        camaraFace.enabled = false;
        camaraLado.enabled = false;
        camaraT.enabled = true;

        camaraFPS.GetComponent<AudioListener>().enabled = false;
        camaraFace.GetComponent<AudioListener>().enabled = false;
        camaraLado.GetComponent<AudioListener>().enabled = false;
        camaraT.GetComponent<AudioListener>().enabled = true;
        principal.worldCamera = camaraT;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            ponerFPS();
        }
    }
}
