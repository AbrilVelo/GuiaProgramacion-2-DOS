using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class While02 : MonoBehaviour
{
    //Realizar un programa que muestre los números 
    //enteros dos enteros ingresados por el usuario
    //Chequear que no sean iguales

    public int num1;
    public int num2;
    void Start()
    {

        if (num1 == num2)
        {
            Debug.Log("Los numeros son Iguales");
        }
        else if(num1 != num2)
        {
            while (num1 <= num2)
            {
                Debug.Log(num1);
                num1++;
            }
            while (num2 <= num1)
            {
                Debug.Log(num2);
                num2++;
            }
        }
        

        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
