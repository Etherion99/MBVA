using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Vida : MonoBehaviour
{  
    public int porcentaje = 100;
    public GameObject recortador;
    public Text texto;
    public GameObject normal, inestable, critica;
    public static Text vi;
    public AccionesPrincipal ac;
    
    public void modificar(int variacion){
        porcentaje += variacion;

        porcentaje = porcentaje > 100 ? 100 : porcentaje < 0 ? 0 : porcentaje;
        Debug.Log(porcentaje);

        actualizarUI();
    }

    void restaurar(){
        porcentaje = 100;
        actualizarUI();
    }

    //void Awake()
    //{
      //  DontDestroyOnLoad(gameObject);
    //}

    void actualizarUI(){
        float max = 289f;

        if(porcentaje > 50){
            critica.SetActive(false);
            inestable.SetActive(false);
            normal.SetActive(true);
            texto.text = porcentaje + "% Estable";
        }else if(porcentaje > 25){
            critica.SetActive(false);
            normal.SetActive(false);
            inestable.SetActive(true);
            texto.text = porcentaje + "% Inestable";
        }else{
            inestable.SetActive(false);
            normal.SetActive(false);
            critica.SetActive(true);
            texto.text = porcentaje + "% Crítico";
        }
        vi=texto;
        recortador.GetComponent<RectTransform>().sizeDelta = new Vector2((100 - porcentaje) * max / 100, 41.5f);
        if (porcentaje == 0)
        {
            ac.end();
        }
    }

    public Text getVida()
    {
        return texto;
    }
}
