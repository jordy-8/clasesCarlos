using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTest : MonoBehaviour
{
    public int health;
    internal void Deactivate()
    {
        this.gameObject.SetActive(false);
    }

    internal void TakeDamage(int damage)
    {
        health -= damage;
        if(health <= 0)
        {
            //Destroy(gameObject);
        }
    }
}
