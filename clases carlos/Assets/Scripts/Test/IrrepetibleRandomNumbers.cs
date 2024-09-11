using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IrrepetibleRandomNumbers : MonoBehaviour
{
    public int[] randomNumbers;
    int newRandomNumber;
    int randomNumbersQuantity = 4;
    int min = -4;
    int max = 4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("g"))
        {
            EraseRandomNumbers();
            GenerateRandomNumbers();            
        }
    }

    void GenerateRandomNumbers()
    {
            for(int i = 0; i <= randomNumbersQuantity - 1; i++)
            {
                newRandomNumber = Random.Range(min, max + 1);
                Debug.Log("randomNumber= " + newRandomNumber);
                CheckRepeated();
                randomNumbers[i] = newRandomNumber;
            }
    }

    void CheckRepeated()
    {
        for(int j = 0; j <= randomNumbersQuantity - 1; j++)
        {
            if(newRandomNumber == randomNumbers[j])
            {
                //genera otro numero aleatorio
                newRandomNumber = Random.Range(min, max + 1);
                //vuelve a comparar
                CheckRepeated();
            }
        }
    }

    void EraseRandomNumbers()
    {
         for(int i = 0; i <= randomNumbersQuantity - 1; i++)
         {
            randomNumbers[i] = min - 1;
         }
    }
}
