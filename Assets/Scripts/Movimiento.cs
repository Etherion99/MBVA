using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movimiento : MonoBehaviour
{
    private Rigidbody body;
    public float speed;
    public float rotar;
    public Camara camaraScript;
    public bool fijar = false;

    private void Start()
    {
        body = GetComponent<Rigidbody>();   
    }

    void Update()
    {
        float hor = Input.GetAxisRaw("Horizontal");
        float ver = Input.GetAxisRaw("Vertical");

        if(!fijar && (hor != 0.0f || ver != 0.0f))
        {
            Vector3 dir = transform.forward * ver + transform.right * hor;

            body.MovePosition(transform.position + dir * speed * Time.deltaTime);
        }

        float mouseHor = Input.GetAxis("Mouse X");
        float yAngle = transform.eulerAngles.y;

        /*if (mouseHor > 0 && yAngle + mouseHor * rotar > 179.5f)
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, 179, transform.eulerAngles.z);
        }
        else if (mouseHor < 0 && yAngle + mouseHor * rotar < 0.5f)
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, 1, transform.eulerAngles.z);
        }
        else
        {*/

        if (camaraScript.lockCursor && !fijar)
        {
            Vector3 CopyR = new Vector3(transform.eulerAngles.x, yAngle + mouseHor * rotar, 0);
            transform.eulerAngles = CopyR;
        }
            
        //}
    }

    void LateUpdate()
    {
        /*if (!lockCamera)
        {
            Vector3 CopyR = new Vector3(0, yAngle + Input.GetAxis("Mouse X") * rotar, 0);
            transform.eulerAngles = CopyR;
        }
        else
        {
            GetComponent<Camera>().transform.eulerAngles = new Vector3(GetComponent<Camera>().transform.eulerAngles.x, GetComponent<Camera>().yAngle + Input.GetAxis("Mouse X") * rotar, 0);
        }*/
        
    }
    void FixedUpdate()
    {
        

    }

}
