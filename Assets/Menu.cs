using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("Livello1");
    }
    public void Chiudi()
    {
        Application.Quit();
        Debug.Log("CHius0");
    }
    public void Continua()
    {
        SceneManager.LoadSceneAsync("Livello2");
    }
}
