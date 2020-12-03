using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opt2 : MonoBehaviour
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
        gameHandler.GetComponent<Option>().dialState += 1;
        gameHandler.GetComponent<Option>().left = false;
        Debug.Log("dialState is " + gameHandler.GetComponent<Option>().dialState);
        Debug.Log("left is " + gameHandler.GetComponent<Option>().left);
        gameHandler.GetComponent<Option>().Invoke("Dialogue", 0.1f);
    }
}

