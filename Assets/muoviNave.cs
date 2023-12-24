using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muoviNave : MonoBehaviour
{
    public float velocitaDritta = 5.0f;
    public float velocita2Dritta = 5.0f;

    public float velocitaCurva = 5.0f;

    public LayerMask luna;

    public Camera camera1;
    public Camera camera2;
    public GameObject cilindro;
    public int tImpulso = 0;

    void Start()
    {
        camera1.enabled = true;
        camera2.enabled = false;
        cilindro.SetActive(false);
    }


    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Vector3 movimentoDritto = new Vector3(0.0f, 0.0f, -1.0f) * velocita2Dritta * Time.deltaTime;
            transform.Translate(movimentoDritto);
        }
        else
        {
            Vector3 movimentoDritto = new Vector3(0.0f, 0.0f, -1.0f) * velocitaDritta * Time.deltaTime;
            transform.Translate(movimentoDritto);
        }
        float rotationAmount = horizontalInput * velocitaCurva * Time.deltaTime;
        transform.Rotate(Vector3.up, rotationAmount);
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.up, out hit))
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
            tImpulso++; 
            camera1.enabled = false;
            camera2.enabled = true;
            cilindro.SetActive(true);
        }
        else
        {
            tImpulso = 0;
            camera1.enabled = true;
            camera2.enabled = false;
            cilindro.SetActive(false);
        }
    }
}