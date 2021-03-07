using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CambiarPreguntas : MonoBehaviour
{
    public GameObject[] paneles;
    public int i=0;
    public GameObject Paso1, paso2, paso3;
    // Start is called before the first frame update

    public void avanzar()
    {
        if (i < paneles.Length)
        {
            paneles[i].gameObject.SetActive(false);
            i = i + 1;
            paneles[i].gameObject.SetActive(true);
            if(i == 5)
            {
                CambiarPaso1();
            }
            if (i == 10)
            {
                CambiarPaso2();
            }
        }
        else 
        {
            paneles[i].gameObject.SetActive(false);
            //SceneManager.LoadScene("Fin", LoadSceneMode.Single);
        }
    }

    public void CambiarPaso1()
    {
        
        Paso1.gameObject.SetActive(false);
        paso2.gameObject.SetActive(true);
    }

    public void CambiarPaso2()
    {
        //System.Threading.Thread.Sleep(3000);
        paso2.gameObject.SetActive(false);
        paso3.gameObject.SetActive(true);
    }
}
