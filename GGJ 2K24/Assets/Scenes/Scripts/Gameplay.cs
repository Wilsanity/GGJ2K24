using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameplay : MonoBehaviour
{
    [SerializeField] private GameObject chooseMenu;
    
    [SerializeField] private GameObject fillMenu;







    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Good()
    {
        Debug.Log("you did good");
    }
    public void Bad()
    {
        Debug.Log("you did bad");
    }

    public void Meh()
    {

    }
}
