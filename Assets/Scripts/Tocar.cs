using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tocar : MonoBehaviour
{
    public GameObject[] canulas;
    public GameObject[] pdfs;
    private Camera camara;
    void Start()
    {
        camara = GetComponent<Camera>();
    }

    void Update()
    {
        /*Ray ray = camara.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.name == "Player")
            {
                Debug.Log("This is a Player");
            }
            else
            {
                Debug.Log("This isn't a Player");
            }
        }*/



        /*Ray ray = camara.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log(hit.transform.name);*/

        /*for(int i = 0; i < canulas.Length; i++)
        {
            if(canulas[i].transform.name == hit.transform.name)
            {
                canulas[i].GetComponent<Renderer>().material.color = Color.red;
            }
        }*/

        /*if (hit.transform.name == "canula amarilla")
        {
            Debug.Log("Amarilla");
        }
        else
        {
            Debug.Log("No");
        }*/
        //}
    }
}
