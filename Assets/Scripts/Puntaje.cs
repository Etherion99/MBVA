using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntaje : MonoBehaviour
{
    public Text Puntuacion;
    public int CantidadPuntos=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //void Awake()
    //{
    //    DontDestroyOnLoad(gameObject);
    //}

    public void ModificarPuntaje(int variacion)
    {
        CantidadPuntos = CantidadPuntos + variacion;

        if (CantidadPuntos < 100)
        {
            Puntuacion.text = "0" + CantidadPuntos.ToString();
        }
        else
        {
            Puntuacion.text = CantidadPuntos.ToString();
        }
        if (CantidadPuntos < 0)
        {
            Puntuacion.text = CantidadPuntos.ToString();
        }
        }
    public int getPuntos()
    {
        return CantidadPuntos;
    }

}
