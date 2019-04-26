using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPlayer : MonoBehaviour
{
    public float fuerzaMovimiento = 1.0f;

    public string izquierdaInputKey = "left";
    public string derechaInputKey = "right";
    public string arribaInputKey = "up";
    public string abajoInputKey = "down";

    public bool player2 = false;

    private Rigidbody rigidbody;

    private bool izquierda;
    private bool derecha;
    private bool arriba;
    private bool abajo;
    private int points = 0;

    void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        izquierda = Input.GetKey(izquierdaInputKey);
        derecha = Input.GetKey(derechaInputKey);
        arriba = Input.GetKey(arribaInputKey);
        abajo = Input.GetKey(abajoInputKey);
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Item"))
        {
            GameObject.Destroy(other.gameObject);
            points += 1;
        }
    }

    private void OnGUI()
    {
        GUIStyle style = new GUIStyle();
        style.richText = true;

        GUI.Box(new Rect(10, 10, 180, 160), "Jugando...");
        if (player2)
        {
            GUI.Label(new Rect(30, 100, 80, 50), "<color=aqua>Player 2 Puntos: <b><size=30>" + points + "</size></b></color>", style);
        } else
        {
            GUI.Label(new Rect(30, 40, 80, 50), "<color=aqua>Player 1 Puntos: <b><size=30>" + points + "</size></b></color>", style);
        }
    }
}