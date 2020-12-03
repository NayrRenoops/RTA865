using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ConfessionDial : MonoBehaviour
{
    public GameObject gameHandler;
    public TextMeshPro opt3;
    public TextMeshPro opt4;
    public GameObject fire;
    public Text dial;
    public AudioSource laugh;
    
    public float dialState;
    public bool top;

    void Start()
    {
        Cursor.visible = false;
        dialState = 0;
        top = true;
        dial.gameObject.SetActive(true);
        Invoke("Starter", 3);
    }

    public void Starter()
    {
        opt3.gameObject.GetComponent<TextMeshPro>().text = "Who are you?";
        opt4.gameObject.GetComponent<TextMeshPro>().text = "What is this place?";
        opt3.gameObject.SetActive(true);
        opt4.gameObject.SetActive(true);
    }

    public void Dialogue()
    {
        if (dialState == 1 && top == true)
        {
            opt3.gameObject.SetActive(false);
            opt4.gameObject.SetActive(false);
            dial.text = "I am a priest, child. A speaker for our one Almighty Lord.";
            Invoke("Choice1a", 3);
        }
        else if (dialState == 1 && top == false)
        {
            opt3.gameObject.SetActive(false);
            opt4.gameObject.SetActive(false);
            dial.text = "Have you never been to confession? It is a cleansing sensation.";
            Invoke("Choice1b", 3);
        }
        else if (dialState == 2 && top == true)
        {
            opt3.gameObject.SetActive(false);
            opt4.gameObject.SetActive(false);
            dial.text = "Don't we all? Go on... there's no shame in it.";
            Invoke("Choice2", 3);
        }
        else if (dialState == 2 && top == false)
        {
            opt3.gameObject.SetActive(false);
            opt4.gameObject.SetActive(false);
            dial.text = "Now now, there's no need to be afraid. There is no judgment within these holy walls.";
            Invoke("Choice2", 3);
        }
        else if (dialState == 3 && top == true)
        {
            opt3.gameObject.SetActive(false);
            opt4.gameObject.SetActive(false);
            dial.text = "Yes... Continue...";
            Invoke("Choice3", 3);
        }
        else if (dialState == 3 && top == false)
        {
            opt3.gameObject.SetActive(false);
            opt4.gameObject.SetActive(false);
            dial.text = "You must...";
            Invoke("Choice3", 3);
        }
        else if (dialState == 4 && top == true)
        {
            opt3.gameObject.SetActive(false);
            opt4.gameObject.SetActive(false);
            dial.text = "Yesss...";
            Invoke("Choice4", 3);
        }
        else if (dialState == 4 && top == false)
        {
            opt3.gameObject.SetActive(false);
            opt4.gameObject.SetActive(false);
            dial.text = "This will never cease.";
            Invoke("Choice4", 3);
        }
        else if (dialState == 5 && top == true)
        {
            opt3.gameObject.SetActive(false);
            opt4.gameObject.SetActive(false);
            dial.text = "...";
            Invoke("Choice5", 3);
        }
        else if (dialState == 5 && top == false)
        {
            opt3.gameObject.SetActive(false);
            opt4.gameObject.SetActive(false);
            dial.text = "...";
            Invoke("Choice5", 3);
        }
        else if (dialState == 6 && top == true)
        {
            opt3.gameObject.SetActive(false);
            opt4.gameObject.SetActive(false);
            dial.text = "...";
            Invoke("Choice6", 3);
        }
        else if (dialState == 6 && top == false)
        {
            opt3.gameObject.SetActive(false);
            opt4.gameObject.SetActive(false);
            dial.text = "...";
            Invoke("Choice6", 3);
        }
    }

    public void Choice1a() 
    {
        dial.text = "Tell me... Have you something to confess?";
        opt3.gameObject.GetComponent<TextMeshPro>().text = "Yes.";
        opt4.gameObject.GetComponent<TextMeshPro>().text = "No.";
        opt3.gameObject.SetActive(true);
        opt4.gameObject.SetActive(true);
    }

    public void Choice1b() 
    {
        dial.text = "Tell me, young one... Have you something to confess?";
        opt3.gameObject.GetComponent<TextMeshPro>().text = "Yes.";
        opt4.gameObject.GetComponent<TextMeshPro>().text = "No.";
        opt3.gameObject.SetActive(true);
        opt4.gameObject.SetActive(true);
    }

    public void Choice2() 
    {
        opt3.gameObject.GetComponent<TextMeshPro>().text = "I hurt someone.";
        opt4.gameObject.GetComponent<TextMeshPro>().text = "I can't.";
        opt3.gameObject.SetActive(true);
        opt4.gameObject.SetActive(true);
    }

    public void Choice3() 
    {
        opt3.gameObject.GetComponent<TextMeshPro>().text = "I tore them apart.";
        opt4.gameObject.GetComponent<TextMeshPro>().text = "Please, stop!";
        opt3.gameObject.SetActive(true);
        opt4.gameObject.SetActive(true);
    }

    public void Choice4() 
    {
        opt3.gameObject.GetComponent<TextMeshPro>().text = "I killed them.";
        opt4.gameObject.GetComponent<TextMeshPro>().text = "It wasn't me it wasn't it wasn't me it wasn't me it wasn't me";
        opt3.gameObject.SetActive(true);
        opt4.gameObject.SetActive(true);
    }

    public void Choice5() 
    {
        opt3.gameObject.GetComponent<TextMeshPro>().text = "And I enjoyed it...";
        opt4.gameObject.GetComponent<TextMeshPro>().text = "And I enjoyed it...";
        opt3.gameObject.SetActive(true);
        opt4.gameObject.SetActive(true);
    }

    public void Choice6() 
    {
        laugh.Play(0);
        dial.text = "HEHEHEHEHEHEHEHEHEHEHEHEHEHEHEHEHEHEHEHEHEHE!";
        fire.gameObject.SetActive(true);
        Invoke("Choice7", 3);
    }

    public void Choice7()
    {
        dial.text = "COME, LET US MEET THE TRUE LORD! IN THY HELLISH DOMAIN!!!";
        Invoke("Choice8", 8);
    }

    public void Choice8()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
