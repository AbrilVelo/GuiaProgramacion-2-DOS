using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class While01 : MonoBehaviour
{
    //Realizar un programa que muestre los números 
    //del 1 al 100 utilizando la instrucción while

    int counter = 1;
    int counterMax = 100;
    
    void Start()
    {
        while (counter <= counterMax)
        {
            Debug.Log("Este mensaje se repetirá. Ésta es la " + counter + " vuelta ");
            counter++;
        }
        Debug.Log("Se terminó el while");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
