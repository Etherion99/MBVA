using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameData : MonoBehaviour
{
    public static int tiempoJuego;
    public static string NombreUsuario = "";
    public Inicio ini;
    public Text inputUsuario;
    public static Text vidaPaciente, puntosJuego, tiempoRestante;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Awake() 
    {
        DontDestroyOnLoad(gameObject);
    }
    // Update is called once per frame
    public void SetTF()
    {
        ini.SetTiempoFacil();
        tiempoJuego = 600;
    }

    public void SetTM()
    {
        ini.SetTiempoMedio();
        tiempoJuego = 360;
    }

    public void SetTD()
    {
        ini.SetTiempoDificil();
        tiempoJuego = 240;    
    }

    public void SetTE()
    {
        ini.SetTiempoExperto();
        tiempoJuego = 120;
    }
    public void setNombreUsuario()
    {
        NombreUsuario = inputUsuario.text;
        //Debug.Log(NombreUsuario);
    }
}
