using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimCanula : MonoBehaviour
{
    public CambioCamara cambio;
    public AnimarPersonaje anim;
    public GameObject canula, tongue;
    public float delta = 0, delta2 = 0;
    public bool m = false;
    public Vector3 initPos, initEul, initPosT, initEulT;

    void Start()
    {
        cambio.ponerLado();

        initPos = canula.transform.position;
        initEul = canula.transform.eulerAngles;

        initPosT = tongue.transform.position;
        initEulT = tongue.transform.eulerAngles;

        canula.gameObject.SetActive(true);
        //anim.openJaw();
    }

    // Update is called once per frame
    void Update()
    {
        float step = 0.005f * Time.deltaTime;

        if (delta <= 0.01f)
        {
            delta += step;
            canula.transform.position = new Vector3(canula.transform.position.x - step * .0f, canula.transform.position.y - step * 4.3f, canula.transform.position.z);
        }
        else
        {
            m = true;
        }

        if (m && delta2 <= 0.01f)
        {
            delta2 += step;
            canula.transform.eulerAngles = new Vector3(canula.transform.eulerAngles.x- step*2000, canula.transform.eulerAngles.y - step * 16000, canula.transform.eulerAngles.z);
            tongue.transform.eulerAngles = new Vector3(tongue.transform.eulerAngles.x, tongue.transform.eulerAngles.y, tongue.transform.eulerAngles.z - step * 2000);
            tongue.transform.position = new Vector3(tongue.transform.position.x, tongue.transform.position.y + step * .4f, tongue.transform.position.z);
        }
    }
    
    public void reset()
    {
        delta = 0;
        delta2 = 0;
        canula.transform.position = initPos;
        canula.transform.eulerAngles = initEul;
        tongue.transform.position = initPosT;
        tongue.transform.eulerAngles = initEulT;
    }
}
