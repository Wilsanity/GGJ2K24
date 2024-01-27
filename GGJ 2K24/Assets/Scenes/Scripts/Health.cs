using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    [SerializeField] int health;
    [SerializeField] int maxHealth;

    private void Start()
    {
        health = maxHealth;


    }


    public void TakeDamage(int damage)
    {
        if(health >= maxHealth)
        {
            health = maxHealth;
        }
        else
        {
            health -= damage;
        }
    }


    public void Die()
    {
        if (health <= 0)
        {
            health = 0;
            //SceneManager.LoadScene("MainMenu");
        }
    }

}

