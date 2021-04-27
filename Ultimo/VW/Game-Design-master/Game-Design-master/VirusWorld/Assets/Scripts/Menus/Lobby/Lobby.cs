/*
Emilio Sanchez 
Rafael Rios
Edgar Rostro

Displays either of the loser or victory menu
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lobby : MonoBehaviour
{
    public GameObject victoria;
    public GameObject perdedor;

    public void Victoria()
    {
        victoria.SetActive(true);
        perdedor.SetActive(false);
        Time.timeScale = 0f;
    }

    public void Perdedor()
    {
        perdedor.SetActive(true);
        victoria.SetActive(false);
        Time.timeScale = 0f;
    }

    public void Resumir()
    {
        Time.timeScale = 1f;
        perdedor.SetActive(false);
        victoria.SetActive(false);
    }

    public void Salir()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Inicio");
    }
}
