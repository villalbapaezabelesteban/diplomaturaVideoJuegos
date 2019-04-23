using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPlayer : MonoBehaviour
{
    float movimientoNeutro = 0.0f;

    public float movimientoHorizontal = 0.1f;
    public float movimientoVertical = 0.1f;

    public float fuerzaMovimiento = 1.0f;

    Rigidbody rigidbody;

    void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody>();

    }

    void Update()
    {
        if (rigidbody != null)
        {
            bool izquierda = Input.GetKey("left");
            bool derecha = Input.GetKey("right");
            bool arriba = Input.GetKey("up");
            bool abajo = Input.GetKey("down");

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
