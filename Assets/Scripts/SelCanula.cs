using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class SelCanula : MonoBehaviour
{
    MeshRenderer renderer;
    public Interaccion controlador;
    public AccionesPrincipal ac;
    public Puntaje puntos;
    public Vida vida;
    public GameObject[] paneles;
    public GameObject panel;
    public Canula canula;
    public int sel;
    public GameObject selecc;

    void Awake()
    {
        renderer = GetComponent<MeshRenderer>();
    }

    void OnMouseDown()
    {
        for(int i = 0; i < paneles.Length; i++)
        {
            paneles[i].gameObject.SetActive(false);
        }

        panel.gameObject.SetActive(true);
        selecc.gameObject.SetActive(true);

        canula.canula = sel;
    }
}
