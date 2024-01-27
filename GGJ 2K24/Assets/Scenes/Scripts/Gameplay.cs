using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameplay : MonoBehaviour
{
    [SerializeField] private GameObject chooseMenu;
    
    [SerializeField] private GameObject fillMenu;

    [SerializeField] private Health healthbar;
    [SerializeField] private JokeOMeter laugh;



    private int losingStreak = 0;
    [SerializeField] int damage = 25;

    private int loseCount;
    private int winCount;


    void Start()
    {
        healthbar = GetComponent<Health>();
        chooseMenu.SetActive(true);
        fillMenu.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Good()
    {
        winCount++;
        laugh.AddLaugh(25);
        NextGame();
    }
    public void Bad()
    {
        loseCount++;
        losingStreak++;
        if(losingStreak == 2)
        {
            
            losingStreak = 0;
        }
        healthbar.TakeDamage(damage);
        NextGame();
    }

    public void Meh()
    {
        healthbar.TakeDamage(10);
        laugh.AddLaugh(10);
        NextGame();
    }

    private void NextGame()
    {
        if(chooseMenu.activeInHierarchy == true)
        {
            chooseMenu.SetActive(false);
            fillMenu.SetActive(true);
        }
        else
        {
            chooseMenu.SetActive(true);
            fillMenu.SetActive(false);
        }
    }
}
