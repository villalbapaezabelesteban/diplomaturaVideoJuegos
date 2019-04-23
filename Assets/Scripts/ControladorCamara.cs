using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorCamara : MonoBehaviour
{
    private GameObject playerAbel;
    private Vector3 desplazamiento;

    // Start is called before the first frame update
    void Start()
    {
        playerAbel = GameObject.FindWithTag("PlayerAbel");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
