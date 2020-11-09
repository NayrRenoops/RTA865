using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class camZoom : MonoBehaviour
{
    public CinemachineVirtualCamera vcam;
    
    public float zoomFOV = 25f;
    private float baseFOV = 70f;
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
            vcam.m_Lens.FieldOfView = zoomFOV;
        else 
            vcam.m_Lens.FieldOfView = baseFOV;
    }
}
