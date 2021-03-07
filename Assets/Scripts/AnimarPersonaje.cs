using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimarPersonaje : MonoBehaviour
{
    public CambiarPreguntas paneles;
    public GameObject jaw, tongue, head;
    public Vector3 jawInit, jawOpen;
    public bool open = false, close = false;
    public float delta = 0;
    void Start()
    {
        
    }

    void Update()
    {
        float step = 0.005f * Time.deltaTime;
        
        if (open)
        {
            if(delta > 0.01f)
            {
                open = false;                
            }
            else
            {
                delta += step;
                jaw.transform.position = new Vector3(jaw.transform.position.x - step, jaw.transform.position.y, jaw.transform.position.z);
                head.transform.eulerAngles = new Vector3(head.transform.eulerAngles.x, head.transform.eulerAngles.y, head.transform.eulerAngles.z - step*1000);
                tongue.transform.position = new Vector3(tongue.transform.position.x - step*.8f, tongue.transform.position.y+step*.1f, tongue.transform.position.z);
                tongue.transform.eulerAngles = new Vector3(tongue.transform.eulerAngles.x, tongue.transform.eulerAngles.y, tongue.transform.eulerAngles.z + step*2000);
            }            
        }
        else if (close)
        {
            if (delta > 0.015f)
            {
                close = false;
            }
            else
            {
                delta += step;
                jaw.transform.position = new Vector3(jaw.transform.position.x + step, jaw.transform.position.y, jaw.transform.position.z);
            }
        }
    }

    public void openJaw()
    {
        delta = 0;
        open = true;
    }

    public void closeJaw()
    {
        delta = 0;
        close = true;
    }
}
