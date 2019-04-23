using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorCamara : MonoBehaviour
{
    public float delay = 0.1f;

    private GameObject playerAbel;
    private Vector3 desplazamiento;

    void Start()
    {
        playerAbel = GameObject.FindWithTag("PlayerAbel");
        desplazamiento = transform.position - playerAbel.transform.position;
    }

    void Update()
    {
        Vector3 posicionActual = transform.position;
        Vector3 posicionFinal = desplazamiento + playerAbel.transform.position;

        transform.position = Vector3.Lerp(posicionActual, posicionFinal, delay * Time.deltaTime);
    }
}