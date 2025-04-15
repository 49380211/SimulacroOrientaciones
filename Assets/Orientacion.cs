using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orientacion : MonoBehaviour
    

{
    public string nombre;
    public int año;
    public string orientation;

    // Start is called before the first frame update
    void Start()
    {
        if (nombre == "")
        {
            Debug.Log("Ingrese un nombre valido");
            return;
        }

        if (año < 1 || año > 5)
        {
            Debug.Log("Año ingresado no valido");
            return;
        }

        if (orientation != "T" && orientation != "H" && orientation != "D" && orientation != "M" && orientation != "G")
        {
            Debug.Log("Solo puede ingresar T, D, G, M o H");
            return;
        }

        if (año < 3) 
        {
            Debug.Log("Error. Aun estas en ciclo basico");
            return;
        }
                    
            Debug.Log ("Muchas gracias " + nombre + "!");

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
