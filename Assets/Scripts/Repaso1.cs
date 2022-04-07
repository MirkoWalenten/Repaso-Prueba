using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Crea un programa que permita ingresar por inspector dos valores enteros y responda si son iguales o no lo son.
public class Repaso1 : MonoBehaviour
{
    public int num1;
    public int num2;
    // Start is called before the first frame update
    void Start()
    {
        if (num1 == num2)
        {
            Debug.Log("Los numeros ingresados son iguales");
        } 
        else
        {
            Debug.Log("Los numeros ingresados NO son iguales");
        }
         

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
