using System;
using System.Collections;
using UnityEngine;

public class Animation : MonoBehaviour
{ 
    public float floatAmplitude = 0.1f; // altura del vaivén
    public float floatFrequency = 1f;   // velocidad del vaivén

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float newY = startPosition.y + Mathf.Sin(Time.time * floatFrequency) * floatAmplitude;
        transform.position = new Vector3(startPosition.x, newY, startPosition.z);
    }
}
