using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IrrepetibleRandomPositions : MonoBehaviour
{
    public Vector2[] randomPositions;
    Vector2 newRandomPosition;
    int randomNumbersQuantity = 4;
    int min = -4;
    int max = 4;
    
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
                newRandomPosition = new Vector2(Random.Range(min, max + 1), Random.Range(min, max + 1));                
                //Debug.Log("randomNumber= " + newRandomNumber);
                CheckRepeated();
                randomPositions[i] = newRandomPosition;
            }
    }

    void CheckRepeated()
    {
        for(int j = 0; j <= randomNumbersQuantity - 1; j++)
        {
            if(newRandomPosition == randomPositions[j])
            {
                //genera otra posicion aleatoria
                newRandomPosition = new Vector2(Random.Range(min, max + 1), Random.Range(min, max + 1));
                //vuelve a comparar
                CheckRepeated();
            }
        }
    }

    void EraseRandomNumbers()
    {
         for(int i = 0; i <= randomNumbersQuantity - 1; i++)
         {
            randomPositions[i] = new Vector2(min - 1, min - 1);
         }
    }
}
