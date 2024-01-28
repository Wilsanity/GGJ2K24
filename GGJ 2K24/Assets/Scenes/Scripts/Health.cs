using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] public float health;
    [SerializeField] float maxHealth;

    [SerializeField] private Image healthbar;
    [SerializeField] private Gameplay gameplay;


    private void Start()
    {
        health = maxHealth;


    }


    public void TakeDamage(int damage)
    {
        

        health -= damage;

        Debug.Log("take damage");

        if(health <= 0)
        {
            gameplay.LoseGame();
        }

        UpdateHealth();
    }


    public void AddHealth(int healthBonus)
    {
        if (health >= maxHealth)
        {
            health = maxHealth;
        }
        else
        {
            health += healthBonus;
        }

        UpdateHealth();
    }

    private void UpdateHealth()
    {
        Debug.Log("hurt");
        Debug.Log(health);
        
        healthbar.fillAmount = health/100;

        Debug.Log(healthbar.fillAmount);
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

