using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Highlight : MonoBehaviour
{
    TextMeshPro m_TextMeshPro;

    void Start()
    {
        m_TextMeshPro = GetComponent<TextMeshPro>();
    }

    void OnMouseOver()
    {
        m_TextMeshPro.color = Color.yellow;
    }

    void OnMouseExit() 
    {
        m_TextMeshPro.color = Color.white;
    }
}
