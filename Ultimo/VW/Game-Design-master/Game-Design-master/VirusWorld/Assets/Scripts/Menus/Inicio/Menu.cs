/*
Emilio Sanchez 
Rafael Rios
Edgar Rostro

Starts the game and restart global values
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    api apu;

    public void Start()
    {
        apu = GetComponent<api>();
    } 

    public void inicio()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene("Registro");
    }

    public void opciones()
    {
        SceneManager.LoadScene("Opciones");
    }

    public void iniciarJuego()
    {
        SceneManager.LoadScene("Mapa");
        StartCoroutine(apu.uploadData());
    }
}