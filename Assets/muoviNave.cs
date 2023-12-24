using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muoviNave : MonoBehaviour
{
    public float velocitaDritta = 5.0f;
    public float velocitaCurva = 5.0f;
    public LayerMask luna;

    public Camera camera1;
    public Camera camera2;

    void Start()
    {
            camera1.enabled = true;
            camera2.enabled = false;
    }


    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector3 movimentoDritto = new Vector3(0.0f, 0.0f, -1.0f) * velocitaDritta * Time.deltaTime;
        float rotationAmount = horizontalInput * velocitaCurva * Time.deltaTime;
        transform.Rotate(Vector3.up, rotationAmount);
        transform.Translate(movimentoDritto);
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, 10f, luna))
        {
            // Se colpisce un oggetto nel layer specificato, continua a giocare.
        }
        else
        {
            // Se non colpisce un oggetto nel layer specificato, attiva la logica di "game over".
            Debug.Log("MORTO");
        }
        if (Input.GetKey(KeyCode.C))
        {
            camera1.enabled = false;
            camera2.enabled = true;

        }
        else
        {
            camera1.enabled = true;
            camera2.enabled = false;
        }
    }
}