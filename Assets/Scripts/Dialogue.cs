using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public GameObject startMenu;
    
    public Text dialogue;
    public TextMeshPro opt1;
    public TextMeshPro opt2;
    public float convoState = 0;

    public Animator detective;

    void Update()
    {
        if (startMenu.activeSelf)
        { }
        else
        {
            Invoke("BeginDialogue", 3);
        }
    }

    public void BeginDialogue()
    {
        dialogue.gameObject.SetActive(true);
        Invoke("ChoiceEnable", 3);
    }

    public void ChoiceEnable()
    {
        if (convoState == 0)
        {
            opt1.gameObject.SetActive(true);
            opt2.gameObject.SetActive(true);
            convoState = 1;
        }
    }
}
