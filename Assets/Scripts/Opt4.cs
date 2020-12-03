using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opt4 : MonoBehaviour
{
    public GameObject gameHandler;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown() 
    {
        gameHandler.GetComponent<ConfessionDial>().dialState += 1;
        gameHandler.GetComponent<ConfessionDial>().top = false;
        Debug.Log("dialState is " + gameHandler.GetComponent<ConfessionDial>().dialState);
        Debug.Log("top is " + gameHandler.GetComponent<ConfessionDial>().top);
        gameHandler.GetComponent<ConfessionDial>().Invoke("Dialogue", 0.1f);
    }
}
