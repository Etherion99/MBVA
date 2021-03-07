using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tareas : MonoBehaviour
{
    public int i = 0;
    public Text task;
    // Start is called before the first frame update

    public void Siguiente()
    {
        i = i + 1;
        switch (i)
        {
            case 1:
                task.text = " - Selecciona el estetoscopio\n\n\t\tPresiona la tecla espacio\n\t\tpara seleccionar con el\n\t\tmaus el estetoscopio\n\n- Posiciona el estetoscopio\n\n\t\tUbicacion correctamente la \n\t\tposición del estetoscopio";
                break;
            case 2:
                task.text = " - Identifica el problema del paciente\n\n\t\tPresiona el icono de sonido\n\t\tpara escuchar la respiración\n\t\tdel paciente.\n\n- Comprueba el estado del paciente\n\n\t\tPresiona el icono de sonido\n\t\tpara escuchar el audio";
                break;
            case 3:
                task.text = " - Revisa la cavidad bucal\n\n\t\tObserva la estructura\n\t\tinterna del paciente\n\t\te identifica el problema.\n\n- Identifica la obstrucción\n\n\t\tPresiona el icono de sonido\n\t\tpara escuchar el audio";
                break;
            case 4:
                task.text = " - Selecciona la canula\n\n\t\tPresiona cualquier canula para\n\t\trevisar la información y\n\t\tselecciona la adecuada.\n\n- Introduce la canula\n\n\tSigue las instrucciones y observa la\n\tforma correcta de introducir la canula";
                break;
            default:
                task.text = "fail";
                break;
        }
    }
}