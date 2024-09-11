using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculadora : MonoBehaviour
{
    public int numeroA;
    public int numeroB;
    int resultado;
    float resFloat;
    int resMul;
    // Start is called before the first frame update
    void Start()
    {
                      
    }

    // Update is called once per frame
    void Update()
    {
        //Suma(numeroA, numeroB); 
        //Resta(numeroA, numeroB);
        Multiplicacion(2, 2, numeroA);
    }

    void Suma(int numA, int numB)
    {
        resultado = numA + numB;
        Debug.Log("res= " + resultado);

    }

    void Resta(float num1, float num2)
    {
        resFloat = num1 - num2;
        Debug.Log("resFloat= " + resFloat);
    }

    void Multiplicacion(int factor1, int numeroB, int tercerElemento)
    {
        resMul = factor1 * numeroB * tercerElemento;
        Debug.Log("mul= " + resMul);
    }
}
