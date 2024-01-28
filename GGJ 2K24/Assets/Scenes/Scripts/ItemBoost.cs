using UnityEngine;
using UnityEngine.UI;

public class ItemBoost : MonoBehaviour
{
    public Button increaseHealthButton;
    public Button nukeButton;
    public Button laughAddButton;

    [SerializeField] private Health healthbar;
    [SerializeField] private JokeOMeter laugh;

    void Start()
    {
        // Assign the onClick functions for each button
        increaseHealthButton.onClick.AddListener(IncreaseHealth);
        nukeButton.onClick.AddListener(Nuke);
        laughAddButton.onClick.AddListener(BoostLaugh);

        // Disable buttons at the beginning
        SetButtonsActive(false);

       
    }

    void SetButtonsActive(bool active)
    {
        increaseHealthButton.interactable = active;
        nukeButton.interactable = active;
        laughAddButton.interactable = active;
    }

    void IncreaseHealth()
    {
        // Implement your logic to increase player health here
        healthbar.AddHealth(20);

        // Disable buttons after clicking
        SetButtonsActive(false);
    }

    void Nuke()
    {
        
        healthbar.TakeDamage(100);

        // Disable buttons after clicking
        SetButtonsActive(false);
    }

    void BoostLaugh()
    {
        // Implement your logic to boost enemy health here

        laugh.AddLaugh(10);
        // Disable buttons after clicking
        SetButtonsActive(false);
    }

    public void EnableRandomButton()
    {
        // Disable all buttons first
        SetButtonsActive(false);

        // Randomly select one of the three buttons
        int randomButton = Random.Range(0, 3);

        switch (randomButton)
        {
            case 0:
                increaseHealthButton.interactable = true;
                increaseHealthButton.onClick.AddListener(IncreaseHealth);
                break;
            case 1:
                nukeButton.interactable = true;
                nukeButton.onClick.AddListener(Nuke);
                break;
            case 2:
                laughAddButton.interactable = true;
                laughAddButton.onClick.AddListener(BoostLaugh);
                break;
        }
    }
}

