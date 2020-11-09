﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class camSwitch : MonoBehaviour
{
    public CinemachineVirtualCamera MenuCam;
    public CinemachineVirtualCamera PlayerCam;

    public GameObject Crosshair;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Submit"))
        {
            MenuCam.m_Priority = 10;
            PlayerCam.m_Priority = 11;
            Crosshair.SetActive(true);
        }
    }
}
