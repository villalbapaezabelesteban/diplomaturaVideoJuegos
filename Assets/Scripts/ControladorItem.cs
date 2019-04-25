using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorItem : MonoBehaviour
{
    public float velocidad = 60f;

    void FixedUpdate()
    {
        transform.Rotate(Vector3.up, velocidad * Time.deltaTime);
    }
}