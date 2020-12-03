using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Option : MonoBehaviour
{
    public GameObject gameHandler;
    public TextMeshPro opt1;
    public TextMeshPro opt2;
    public GameObject ceilingLight;
    public GameObject chair;
    public GameObject jill;
    public Animator jillAnim;
    public Animator detective;
    public Text dial;
    public AudioSource bulbSmash;
    public AudioSource chairFall;
    public AudioSource manDead;
    

    public float scareReady;

    public float dialState;
    public bool left;

    void Start()
    {
        dialState = 0;
        left = true;
    }

    public void Dialogue()
    {
        if (dialState == 1 && left == true)
        {
            opt1.gameObject.SetActive(false);
            opt2.gameObject.SetActive(false);
            detective.SetBool("isCheeky", true);
            dial.text = "Playing dumb, eh?";
            Invoke("Choice1a", 3);
        }
        else if (dialState == 1 && left == false)
        {
            opt1.gameObject.SetActive(false);
            opt2.gameObject.SetActive(false);
            detective.SetBool("isCheeky", true);
            dial.text = "An undisclosed federal interrogation facility.";
            Invoke("Choice1b", 3);
        }
        else if (dialState == 2 && left == true)
        {
            opt1.gameObject.SetActive(false);
            opt2.gameObject.SetActive(false);
            detective.SetBool("isAngry", true);
            dial.text = "Cut the shit!";
            Invoke("Choice2a", 3);
        }
        else if (dialState == 2 && left == false)
        {
            opt1.gameObject.SetActive(false);
            opt2.gameObject.SetActive(false);
            detective.SetBool("isAngry", true);
            dial.text = "Nice try, pal. How about you focus on yourself right now?";
            Invoke("Choice2b", 3);
        }
        else if (dialState == 3 && left == true)
        {
            opt1.gameObject.SetActive(false);
            opt2.gameObject.SetActive(false);
            detective.SetBool("isSad", false);
            dial.text = "Enough of this.";
            Invoke("Choice4a", 3);
        }
        else if (dialState == 3 && left == false)
        {
            opt1.gameObject.SetActive(false);
            opt2.gameObject.SetActive(false);
            detective.SetBool("isSad", false);
            dial.text = "Enough of this.";
            Invoke("Choice4a", 3);
        }
    }

    public void Choice1a() 
    {
        detective.SetBool("isCheeky", false);
        dial.text = "That's not gonna get you very far. Talk.";
        opt1.gameObject.GetComponent<TextMeshPro>().text = "I... I don't know anything.";
        opt2.gameObject.GetComponent<TextMeshPro>().text = "There's someone behind you!";
        opt1.gameObject.SetActive(true);
        opt2.gameObject.SetActive(true);
    }

    public void Choice1b() 
    {
        detective.SetBool("isCheeky", false);
        dial.text = "Now it's your turn to share. Talk.";
        opt1.gameObject.GetComponent<TextMeshPro>().text = "I... I don't know anything.";
        opt2.gameObject.GetComponent<TextMeshPro>().text = "There's someone behind you!";
        opt1.gameObject.SetActive(true);
        opt2.gameObject.SetActive(true);
    }

    public void Choice2a() 
    {
        detective.SetBool("isAngry", false);
        dial.text = "Your DNA's all over the crime scene. Prints, hair, blood, we have it all.";
        jill.gameObject.SetActive(true);
        Invoke("Choice3a", 7);
    }

    public void Choice2b() 
    {
        detective.SetBool("isAngry", false);
        dial.text = "Your DNA was all over the body. Your prints were pressed around her throat!";
        jill.gameObject.SetActive(true);
        Invoke("Choice3b", 7);
    }

    public void Choice3a()
    {
        detective.SetBool("isSad", true);
        dial.text = "Her face... I've never seen it done like that... You sick bastard.";
        opt1.gameObject.GetComponent<TextMeshPro>().text = "I swear it wasn't me! Please, I can't go to jail!";
        opt2.gameObject.GetComponent<TextMeshPro>().text = "Turn around! TURN AROUND!!";
        opt1.gameObject.SetActive(true);
        opt2.gameObject.SetActive(true);
    }

    public void Choice3b()
    {
        detective.SetBool("isSad", true);
        dial.text = "The blood... Everywhere... I've never seen anything like it.";
        opt1.gameObject.GetComponent<TextMeshPro>().text = "I swear it wasn't me! Please, I can't go to jail!";
        opt2.gameObject.GetComponent<TextMeshPro>().text = "Turn around! TURN AROUND!!";
        opt1.gameObject.SetActive(true);
        opt2.gameObject.SetActive(true);
    }

    public void Choice4a()
    {
        detective.SetBool("isStanding", true);
        dial.text = "I'm gonna enjoy watching you rot.";
        Invoke("Choice4b", 3);
    }

    public void Choice4b()
    {
        ceilingLight.gameObject.SetActive(false);
        jill.gameObject.SetActive(false);
        chair.gameObject.transform.position = new Vector3(0.57f, 0.28f, -2.516f);
        chair.gameObject.transform.rotation = Quaternion.Euler(-90f, 0, -38.079f);
        detective.gameObject.transform.position = new Vector3(0.6f, 0, -2f);
        bulbSmash.Play(0);
        chairFall.PlayDelayed(0.75f);
        dial.text = "H-hey?! The lights! What happened to the-";
        Invoke("Choice4c", 3.5f);
    }

    public void Choice4c()
    {
        manDead.Play(0);
        dial.text = "HURK!!";
        detective.SetBool("isDead", true);
        jill.gameObject.SetActive(true);
        jill.gameObject.transform.position = new Vector3(4.137f, 1.489f, 0.534f);
        jill.gameObject.transform.rotation = Quaternion.Euler(38f, -164.3f, -0.219f);
        jillAnim.SetBool("isCeiling", true);
        ceilingLight.gameObject.SetActive(true);
        ceilingLight.gameObject.GetComponent<Light>().range = 4;
        scareReady = 1;
        Invoke("Choice5", 1);
    }

    public void Choice5()
    {
        dial.gameObject.SetActive(false);
    }
}
