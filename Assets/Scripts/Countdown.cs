using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour
{

    public GameObject TimerBlue,TimerRed, TimerYellow, BarraMinus, PuntosRed;
    public Text timerUI, texto;
    public AccionesPrincipal ac;
    //public static Text ti;
    public double remainig = 0f;

    void Start()
    {
        startCountdown(GameData.tiempoJuego);
    }

    //void Awake()
    //{
      //  DontDestroyOnLoad(gameObject);
    //}

    void Update()
    {
        if(remainig > 0)
        {
            int middle = GameData.tiempoJuego / 2;
            int low = GameData.tiempoJuego / 4;
            remainig -= Time.deltaTime;
            updateTimer((int) Math.Ceiling(remainig));
            if (remainig <= middle)
            {
                TimerYellow.gameObject.SetActive(true);
                timerUI.color = new Color(254, 247, 75);
                texto.color = new Color(254, 247, 75);
                TimerBlue.gameObject.SetActive(false);
                if (remainig <= low)
                {
                    TimerRed.gameObject.SetActive(true);
                    timerUI.color = new Color(254, 0, 0);
                    texto.color = new Color(254, 0, 0);
                    TimerYellow.gameObject.SetActive(false);
                }
            }

            if(remainig < 60)
            {
                texto.text = "Segs";
            }
        }
        else
        {
            remainig = 0;
            ac.end();
        }
    }

    void startCountdown(int secs)
    {
        remainig = secs;
    }

    void updateTimer(int secs)
    {
        int mins = (int)(secs / 60);
        secs -= mins * 60;

        String minsTxt = mins <= 9 ? "0" + mins : mins.ToString();
        String secsTxt = secs <= 9 ? "0" + secs : secs.ToString();

        timerUI.text = minsTxt + ":" + secsTxt;
       //ti = timerUI;
    }

    public Text getTimer()
    {
        return timerUI;
    }

}
