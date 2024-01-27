using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChooseGame : MonoBehaviour
{
    [SerializeField] private Gameplay gameplay;
    [SerializeField] private List<string> jokes;
    [SerializeField] private List<int> weights;
    [SerializeField] private string[] chosenJokes = new string[4];
    [SerializeField] private int[] weight = new int[4];
    [SerializeField] private TextMeshProUGUI[] outputJokes = new TextMeshProUGUI[4];
     private string playerJoke;



    private void OnEnable()
    {
        int iterator = 0;
        while(iterator < 4)
        {

            int random = Random.Range(0, jokes.Count);

            //string temp = jokes[random];

            if(jokes[random] != chosenJokes[0] && jokes[random] != chosenJokes[1] && jokes[random] != chosenJokes[2] && jokes[random] != chosenJokes[3])
            {
                chosenJokes[iterator] = jokes[random];
                weight[iterator] = weights[random];
                weights.RemoveAt(random);
                jokes.RemoveAt(random);
                iterator++;
            }


        }
        

        
    }

    public void ChosenJoke(int choice)
    {
        playerJoke = chosenJokes[choice];
        Debug.Log(playerJoke);

        if(weight[choice] == 2)
        {
            gameplay.Good();
        }
        else if(weight[choice] == 1)
        {
            gameplay.Meh();
        }
        else
        {
            gameplay.Bad();
        }
    }
}
