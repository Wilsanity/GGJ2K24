using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JokeOMeter : MonoBehaviour
{
    [SerializeField] public float laugh;
    [SerializeField] float minLaugh = 0;

    [SerializeField] private Image laughBar;
    [SerializeField] private Gameplay gameplay;



    private void Start()
    {
        laugh = minLaugh;


    }

    public void AddLaugh(int laughBonus)
    {
        laugh += laughBonus;

        UpdateLaugh();

        if(laugh >= 100)
        {
            gameplay.WinGame();
        }
    }

    private void UpdateLaugh()
    {


        laughBar.fillAmount = laugh / 100;


    }

}