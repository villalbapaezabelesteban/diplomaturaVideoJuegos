using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorCamara : MonoBehaviour
{
    public float delay = 0.1f;

    private GameObject[] players;
    private Vector3 desplazamiento;

    void Start()
    {
        players = GameObject.FindGameObjectsWithTag("PlayerAbel");
        desplazamiento = transform.position - GetPromedioPosiciones();
    }

    void Update()
    {
        Vector3 posicionActual = transform.position;
        Vector3 posicionFinal = desplazamiento + GetPromedioPosiciones();

        transform.position = Vector3.Lerp(posicionActual, posicionFinal, delay * Time.deltaTime);
    }

    private Vector3 GetPromedioPosiciones()
    {
        Vector3 promedioDesplazamiento = Vector3.zero;

        foreach (var player in players)
        {
            promedioDesplazamiento += player.transform.position;
        }

        promedioDesplazamiento /= players.Length;

        return promedioDesplazamiento;
    }
}