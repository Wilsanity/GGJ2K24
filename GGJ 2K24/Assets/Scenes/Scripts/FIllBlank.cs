using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FIllBlank : MonoBehaviour
{
    [SerializeField] private Gameplay gameplay;
    [SerializeField] private string jokes1;
    [SerializeField] private string jokes2;
    [SerializeField] private string jokes3;
    [SerializeField] private string[] response1;
    [SerializeField] private string[] response2;
    [SerializeField] private string[] response3;
    [SerializeField] private int[] weight1;
    [SerializeField] private int[] weight2;
    [SerializeField] private int[] weight3;


    [SerializeField] TextMeshProUGUI jokeBlank;
    [SerializeField] private TextMeshProUGUI[] responses = new TextMeshProUGUI[4];
    private string playerJoke;
    private int loop = 0;

    private string currentJoke;
    private string[] currentAnswers;
    private int[] currentWeight;



    private void OnEnable()
    {
        loop++;

        switch (loop)
        {
            case 1:
                currentJoke = jokes1;
                currentAnswers = response1;
                currentWeight = weight1;
                break;
            case 2:
                currentJoke = jokes2;
                currentAnswers = response2;
                currentWeight = weight2;
                break;
            case 3:
                currentJoke = jokes3;
                currentAnswers = response3;
                currentWeight = weight3;
                break;
        }
        jokeBlank.text = currentJoke;

        for(int i = 0; i <= 3; i++)
        {
            responses[i].text = currentAnswers[i];

        }


    }

    public void ChosenJoke(int choice)
    {
        
        if (currentWeight[choice] == 2)
        {
            gameplay.Good();
        }
        else if (currentWeight[choice] == 1)
        {
            gameplay.Meh();
        }
        else
        {
            gameplay.Bad();
        }
    }
}
