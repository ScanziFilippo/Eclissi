using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;  // Assegna la trasformazione dell'aereo a questo campo
    public float distance = 5.0f;  // Distanza iniziale della camera dall'aereo
    public float sensitivity = 2.0f;  // Sensibilità del movimento della camera

    private float currentX = 90.0f;
    private float currentY = 0.0f;

    private void Start()
    {
        Cursor.visible = false;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.V))
        {
            // Leggi l'input del mouse per ottenere il movimento
            currentX += Input.GetAxis("Mouse X") * sensitivity;
            currentY -= Input.GetAxis("Mouse Y") * sensitivity;

            // Limita l'angolo Y per prevenire la camera dal girare sopra o sotto l'aereo
            currentY = Mathf.Clamp(currentY, -80f, 80f);

            // Calcola la nuova posizione della camera attorno all'aereo
            Vector3 direction = new Vector3(0, 0, -distance);
            Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);
            Vector3 position = rotation * direction + target.position;

            // Aggiorna la posizione e la rotazione della camera
            transform.rotation = rotation;
            transform.position = position;
        }
    }
}
