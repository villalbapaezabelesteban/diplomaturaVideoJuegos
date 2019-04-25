using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPlayer : MonoBehaviour
{
    public float fuerzaMovimiento = 1.0f;

    private Rigidbody rigidbody;
    private bool izquierda;
    private bool derecha;
    private bool arriba;
    private bool abajo;

    void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        izquierda = Input.GetKey("left");
        derecha = Input.GetKey("right");
        arriba = Input.GetKey("up");
        abajo = Input.GetKey("down");
    }

    void FixedUpdate()
    {
        if (rigidbody != null)
        {
            if (arriba)
            {
                rigidbody.AddForce(Vector3.forward * fuerzaMovimiento);
            }

            if (abajo)
            {
                rigidbody.AddForce(Vector3.back * fuerzaMovimiento);
            }

            if (izquierda)
            {
                rigidbody.AddForce(Vector3.left * fuerzaMovimiento);
            }

            if (derecha)
            {
                rigidbody.AddForce(Vector3.right * fuerzaMovimiento);
            }
        }
    }
}