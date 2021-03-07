using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour {
	public float rotar;
    public bool lockCursor;
    public GameObject manos;
    public Movimiento mov;

    private void Update()
    {
        if (Input.GetKeyUp("space"))
        {
            lockCursor = !lockCursor;
        }

        if (lockCursor)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }

    void LateUpdate(){
        if (lockCursor && !mov.fijar)
        {
            if (Input.GetAxis("Mouse Y") > 0 && transform.eulerAngles.x - Input.GetAxis("Mouse Y") * rotar < 0.5f)
            {
                transform.eulerAngles = new Vector3(359, transform.eulerAngles.y, transform.eulerAngles.z);
            }
            else if (Input.GetAxis("Mouse Y") < 0 && transform.eulerAngles.x - Input.GetAxis("Mouse Y") * rotar > 359.5f)
            {
                transform.eulerAngles = new Vector3(1, transform.eulerAngles.y, transform.eulerAngles.z);
            }
            else
            {
                Vector3 CopyR = new Vector3(transform.eulerAngles.x - Input.GetAxis("Mouse Y") * rotar, transform.eulerAngles.y, 0);
                transform.eulerAngles = CopyR;

                manos.transform.eulerAngles = new Vector3(transform.eulerAngles.x - Input.GetAxis("Mouse Y") * rotar * .5f, transform.eulerAngles.y, 0);
            }
        }        
	}
}
