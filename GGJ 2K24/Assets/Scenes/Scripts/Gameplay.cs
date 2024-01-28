using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameplay : MonoBehaviour
{
    [SerializeField] private GameObject chooseMenu;
    
    [SerializeField] private GameObject fillMenu;

    [SerializeField] private GameObject happyKing; 
    

    [SerializeField] private Health healthbar;
    [SerializeField] private JokeOMeter laugh;

  


    private ItemBoost itemBoost;

    [SerializeField] private Animator animator;

  

    private int losingStreak = 0;
    [SerializeField] int damage = 25;

    private int loseCount;
    private int winCount;


    void Start()
    {
        healthbar = GetComponent<Health>();
        itemBoost = GetComponent<ItemBoost>();
        
        chooseMenu.SetActive(false);
        fillMenu.SetActive(false);
   

    
        happyKing.SetActive(false);

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
            itemBoost.EnableRandomButton();
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

 
    public void LoseGame()
    {
        StartCoroutine(playLoseScene());

    }
    public void WinGame()
    {
        StartCoroutine(playWinScene());
    }

    IEnumerator playLoseScene()
    {
        StartAnimation();

        yield return new WaitForSeconds(2);

        SceneManager.LoadScene("GameOver");
    }


    IEnumerator playWinScene()
    {
        happyKing.SetActive(true);

        yield return new WaitForSeconds(2);

        SceneManager.LoadScene("GameWin");
    }

    public void StartAnimation()
    {
        animator.SetBool("Lose", true);
    }
}
