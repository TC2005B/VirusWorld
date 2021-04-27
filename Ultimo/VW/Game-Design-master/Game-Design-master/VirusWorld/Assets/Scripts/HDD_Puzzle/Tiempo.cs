/*
Emilio Sanchez 
Rafael Rios
Edgar Rostro

Keeps track on time and displays the players score
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tiempo : MonoBehaviour
{
    // Variables visible from Unity
    [SerializeField] Text textTime;
    [SerializeField] Text textMessage;
    [SerializeField] int limit;

    [SerializeField] GameObject hdd;
    // Reference to another script
    DropElem dropper;
    Puntaje puntos;

    int timer;
    public int timeLimit;

    public void startTimer()
    {
        // Get the value from another scene
        timer = limit;
        // Initialize the display text
        textTime.text = "Tiempo: " + timer;
        timeLimit = timer;
        dropper = GetComponent<DropElem>();
        puntos = hdd.GetComponent<Puntaje>();
        InvokeRepeating("CountDown", 1, 1);
    }

    void CountDown()
    {
        timer--;
        textTime.text = "Time: " + timer;
        if (timer == 0 || puntos.score == 10 || puntos.virus == 3)
        {
            GameOver();
        }
    }
    
    void GameOver()
    {
        // Stop the invokes in this and the other script
        dropper.StopDroppping();
        CancelInvoke();
        if (puntos.score >= 10 && puntos.virus < 3)
        {
            PlayerPrefs.SetInt("NC", PlayerPrefs.GetInt("NC", 0) + 1);
            textMessage.text = "¡FELICIDADES, TE SALVASTE DE LOS VIRUS!\nPresiona 'R' para volver a jugar\nPresiona 'M' para continuar con tu aventura";
            PlayerPrefs.SetInt("HDDWIN", PlayerPrefs.GetInt("HDDWIN", 0) + 1);
        }
        else if (puntos.virus >= 3 && puntos.score < 10)
        {
            textMessage.text = "¡PERDISTE, TU COMPUTADORA SE INFECTO!\nPresiona 'R' para reintentar\nPresiona 'M' para volver al mapa";
        }
        else if (timer == 0 && puntos.virus < 3 && puntos.score < 10)
        {
            textMessage.text = "¡PERDISTE, TE QUEDASTE SIN TIEMPO!\nPresiona 'R' para reintentar\nPresiona 'M' para volver al mapa";
        }
        
    }
}
