using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scare : MonoBehaviour
{
    public Animator jill;
    public GameObject gameHandler;
    public AudioSource jumpScare;
    public float scare;

    void Update()
    {
        scare = gameHandler.GetComponent<Option>().scareReady;
    }

    void OnMouseOver()
    {
        if (scare == 1)
        {
            jumpScare.Play();
            jill.SetBool("isAttack", true);
            Invoke("Confession", 0.4f);
        }
    }

    public void Confession()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
