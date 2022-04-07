using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repaso2 : MonoBehaviour
{
    public int prod1;
    public int prod2;
    public int prod3;
    public int dinero;
    // Start is called before the first frame update
    void Start()
    {
        int suma;
        int total;
        suma = prod1 + prod2 + prod3;
        

        if(suma > dinero)
        {
            Debug.Log("Los productos superan el monto de dinero disponible");
            total = suma - dinero;
            Debug.Log("Lo que te falta es " + total);
          
        }
        else
        {
            Debug.Log("Los productos NO superan el monto disponible");
            int sobra;
            sobra = (dinero - suma);
            Debug.Log("Lo que le sobra es" + sobra);
        }
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
