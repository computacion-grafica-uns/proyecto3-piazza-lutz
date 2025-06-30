using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SillaGiratoria : MonoBehaviour
{
    public float rotationSpeed = 200f; // velocidad de rotación

    private Vector3 startPosition;

    void Start()
    {
    }

    void Update()
    {
        transform.rotation = Quaternion.Euler(new Vector3(0, rotationSpeed * Time.time, 0));
    }
}