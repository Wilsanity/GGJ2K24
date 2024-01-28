using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textComponent;

    [TextArea(5, 5)]
    public string[] lines;

    public float textSpeed;

    private int index;

    private void Start()
    {
        
       StartDialogue();
    }

    

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(textComponent.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }

    
    }

    public void StartDialogue()
    {
        textComponent.text = string.Empty; //Clear Dialogue 
        gameObject.SetActive(true);
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        //for each character in the line 
        foreach(char c in lines[index].ToCharArray())
        {
            textComponent.text += c; //Next character
            yield return new WaitForSeconds(textSpeed); 

        }
    }

    void NextLine()
    {
        if(index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty; 
            StartCoroutine(TypeLine());

        }

        else
        {
            gameObject.SetActive(false);
        }
    }
}
