using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Analytics;

public class Record : MonoBehaviour
{
    public Text user, score, time;
    public Canvas canvas5, canvas1;
    public Camera camara5, camara1;
    public void prestart()
    {
        PlayerPrefs.SetInt("PH", 100);
        PlayerPrefs.SetString("name1", "Admin");
        PlayerPrefs.SetString("t1", "00:40");

        PlayerPrefs.SetInt("PM", 80);
        PlayerPrefs.SetString("name2", "Manager");
        PlayerPrefs.SetString("t2", "01:25");

        PlayerPrefs.SetInt("PL", 60);
        PlayerPrefs.SetString("name3", "Pro");
        PlayerPrefs.SetString("t3", "02:28");

        PlayerPrefs.SetInt("PF", 40);
        PlayerPrefs.SetString("name4", "Noob");
        PlayerPrefs.SetString("t4", "03:53");
    }
    public void openRec()
    {
        camara5.enabled = true;
        canvas5.enabled = true;
        camara1.enabled = false;
        canvas1.enabled = false;

        camara5.GetComponent<AudioListener>().enabled = true;
        camara1.GetComponent<AudioListener>().enabled = false;

        AnalyticsResult result = Analytics.CustomEvent("OpenRecords");
        Debug.Log("Analytics result: " + result);
    }

    public void closeRec()
    {
        camara1.enabled = true;
        canvas1.enabled = true;
        camara5.enabled = false;
        canvas5.enabled = false;

        camara1.GetComponent<AudioListener>().enabled = true;
        camara5.GetComponent<AudioListener>().enabled = false;
    }

    public void setNew(int puntos, string usuario, string tiempo)
    {
        int point = puntos;
        if (PlayerPrefs.GetInt("PH") <= point)
        {
            PlayerPrefs.SetInt("PF", PlayerPrefs.GetInt("PL"));
            PlayerPrefs.SetString("name4", PlayerPrefs.GetString("name3"));
            PlayerPrefs.SetString("t4", PlayerPrefs.GetString("t3"));

            PlayerPrefs.SetInt("PL", PlayerPrefs.GetInt("PM"));
            PlayerPrefs.SetString("name3", PlayerPrefs.GetString("name2"));
            PlayerPrefs.SetString("t3", PlayerPrefs.GetString("t3"));

            PlayerPrefs.SetInt("PM", PlayerPrefs.GetInt("PH"));
            PlayerPrefs.SetString("name2", PlayerPrefs.GetString("name1"));
            PlayerPrefs.SetString("t2", PlayerPrefs.GetString("t1"));

            PlayerPrefs.SetInt("PH", point);
            PlayerPrefs.SetString("name1", usuario);
            PlayerPrefs.SetString("t1", tiempo);
            point = 0;
        }

        if (PlayerPrefs.GetInt("PM") <= point)
        {
            
            PlayerPrefs.SetInt("PF", PlayerPrefs.GetInt("PL"));
            PlayerPrefs.SetString("name4", PlayerPrefs.GetString("name3"));
            PlayerPrefs.SetString("t4", PlayerPrefs.GetString("t3"));

            PlayerPrefs.SetInt("PL", PlayerPrefs.GetInt("PM"));
            PlayerPrefs.SetString("name3", PlayerPrefs.GetString("name2"));
            PlayerPrefs.SetString("t3", PlayerPrefs.GetString("t3"));

            PlayerPrefs.SetInt("PM", point);
            PlayerPrefs.SetString("name2", usuario);
            PlayerPrefs.SetString("t2", tiempo);
            point = 0;
        }

        if (PlayerPrefs.GetInt("PL") <= point)
        {
            PlayerPrefs.SetInt("PF", PlayerPrefs.GetInt("PL"));
            PlayerPrefs.SetString("name4", PlayerPrefs.GetString("name3"));
            PlayerPrefs.SetString("t4", PlayerPrefs.GetString("t3"));

            PlayerPrefs.SetInt("PL", point);
            PlayerPrefs.SetString("name3", usuario);
            PlayerPrefs.SetString("t3", tiempo);
            point = 0;
        }

        if (PlayerPrefs.GetInt("PF") <= point)
        {
            PlayerPrefs.SetInt("PF", point);
            PlayerPrefs.SetString("name4", usuario);
            PlayerPrefs.SetString("t4", tiempo);
        }
    }

    public void GetRecords()
    {
        user.text = "Nombre:\n\n\n" + PlayerPrefs.GetString("name1") + "\n\n" + PlayerPrefs.GetString("name2") + "\n\n" + PlayerPrefs.GetString("name3") + "\n\n" + PlayerPrefs.GetString("name4");
        score.text = "Punjate:\n\n\n" + PlayerPrefs.GetInt("PH") + "\n\n" + PlayerPrefs.GetInt("PM") + "\n\n" + PlayerPrefs.GetInt("PL") + "\n\n" + PlayerPrefs.GetInt("PF");
        time.text = "Tiempo Restante:\n\n\n" + PlayerPrefs.GetString("t1") + "\n\n" + PlayerPrefs.GetString("t2") + "\n\n" + PlayerPrefs.GetString("t3") + "\n\n" + PlayerPrefs.GetString("t4");
    }
    
}
