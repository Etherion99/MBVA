using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Analytics;

public class Fin : MonoBehaviour
{
    public Text vida, tiempo, puntos, nombre;
    public Vida vid;
    public Puntaje pun;
    public Countdown tie;
    public GameObject fin, finSecreto;
    public Record rec;
    // Start is called before the first frame update
    void start()
    {
    }

    public void setDatos()
    {
        vida.text = vid.getVida().text;
        tiempo.text = "Tiempo restante: " + tie.getTimer().text + "minutos";
        puntos.text = "Puntuación total: " + pun.getPuntos().ToString();
        
        if (vida.text == "0% Crítico" || tie.getTimer().text == "00:00")
        {
            if(GameData.tiempoJuego == 120)
            {
                nombre.text = GameData.NombreUsuario + ", no conseguiste completar el juego satisfactoriamente en dificultad experto, los resultados obtenidos son: ";
            }
            if (GameData.tiempoJuego == 240)
            {
                nombre.text = GameData.NombreUsuario + ", no conseguiste completar el juego satisfactoriamente en dificultad dificil, los resultados obtenidos son: ";
            }
            if (GameData.tiempoJuego == 360)
            {
                nombre.text = GameData.NombreUsuario + ", no conseguiste completar el juego satisfactoriamente en dificultad medio, los resultados obtenidos son: ";
            }
            if (GameData.tiempoJuego == 600)
            {
                nombre.text = GameData.NombreUsuario + ", no conseguiste completar el juego satisfactoriamente en dificultad facil, los resultados obtenidos son: ";
            }
        }
        else 
        {
            if (GameData.tiempoJuego == 120)
            {
                nombre.text = GameData.NombreUsuario + ", conseguiste completar el juego satisfactoriamente en dificultad experto, ¡enhorabuena! Los resultados obtenidos son: ";
            }
            if (GameData.tiempoJuego == 240)
            {
                nombre.text = GameData.NombreUsuario + ", conseguiste completar el juego satisfactoriamente en dificultad dificil, ¡enhorabuena! Los resultados obtenidos son: ";
            }
            if (GameData.tiempoJuego == 360)
            {
                nombre.text = GameData.NombreUsuario + ", conseguiste completar el juego satisfactoriamente en dificultad medio, ¡enhorabuena! Los resultados obtenidos son: ";
            }
            if (GameData.tiempoJuego == 600)
            {
                nombre.text = GameData.NombreUsuario + ", conseguiste completar el juego satisfactoriamente en dificultad facil, ¡enhorabuena! Los resultados obtenidos son: ";
            }
        }

        AnalyticsResult result = Analytics.CustomEvent("DatosPartida", new Dictionary<string, object>
        {
            { "time", tie.remainig },
            { "score", pun.CantidadPuntos },
            { "life", vid.porcentaje }
        });
        Debug.Log("Analytics result: " + result);
        //GuardarRec();
    }
    public void GuardarRec()
    {
        rec.setNew(pun.getPuntos(), GameData.NombreUsuario, tie.getTimer().text);
    }

    public void selFinal()
    {

        if (pun.getPuntos() == 100 && GameData.tiempoJuego == 120)
        {
            finSecreto.gameObject.SetActive(true);
            fin.gameObject.SetActive(false);
        }
        else 
        {
            finSecreto.gameObject.SetActive(false);
            fin.gameObject.SetActive(true);
        }
    }

}
