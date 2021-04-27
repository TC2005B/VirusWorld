/*
Emilio Sanchez 
Rafael Rios
Edgar Rostro

Stores the score and virus count and displays its
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntaje : MonoBehaviour
{
    // Variables visible from Unity
    [SerializeField] Text textScore;
    [SerializeField] Text textVirus;
    public int score = 0;
    public int virus = 0;

    void OnTriggerEnter2D(Collider2D col)
    {
        // col.collider.name == "VirusIcon"
        if (col.tag == "Archivos")
        {
            score++;
            textScore.text = "Puntos: " + score + "/10";
        }
        // col.collider.name == "VirusIcon"
        else if (col.tag == "VirusIcon")
        {
            virus++;
            textVirus.text = "Virus: " + virus + "/3";
        }
    }
}

