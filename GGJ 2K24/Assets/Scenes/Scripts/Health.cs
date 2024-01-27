using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    [SerializeField] public int health;
    [SerializeField] int maxHealth;

    private void Start()
    {
        health = maxHealth;


    }


    public void TakeDamage(int damage)
    {
        if (health >= maxHealth)
        {
            health = maxHealth;
        }
        else
        {
            health -= damage;
        }
    }


    void AddHealth(int healthBonus)
    {
        if (health >= maxHealth)
        {
            health = maxHealth;
        }
        else
        {
            health += healthBonus;
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

