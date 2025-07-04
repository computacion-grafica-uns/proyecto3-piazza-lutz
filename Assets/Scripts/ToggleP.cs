using System;
using System.Collections;
using System.Collections.Generic;
//using UnityEditor.EditorTools;
using UnityEngine;

public class ToggleP : MonoBehaviour
{
    public GameObject objeto;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (objeto != null)
            {
                objeto.SetActive(!objeto.activeSelf);
            }
            
        }
    }
}
