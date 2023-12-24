using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentoCorpi : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float velocita = 5.0f;
    void Update()
    {
        Vector3 movimentoDritto = new Vector3(-1.0f, 0.0f, 0.0f) * velocita * Time.deltaTime;
        transform.Translate(movimentoDritto);
    }
}
