/*
Emilio Sanchez 
Rafael Rios
Edgar Rostro

Checks the points from the User and decides whether the User has won or not  then displays the corresponding message
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Control : MonoBehaviour
{
    [SerializeField] Text textScore;
    [SerializeField] Text textAttempts;
    [SerializeField] Text textMessage;

    int aciertos = 0;
    int intentos = 3;

    // Update is called once per frame
    public bool acierto;
    public void puntos()
    {
        if (acierto)
        {
            textMessage.text = "¡SEÑAL CORRECTA!\n Sumas un acierto";
            aciertos++;
            textScore.text = "Aciertos: " + aciertos + "/5";
        } 
        else
        {
            textMessage.text = "¡SEÑAL INCORRECTA!\n Pierdes un intento";
            intentos--;
            textAttempts.text = "Intentos: " + intentos + "/3";
        }
        menu();
    }

    void menu()
    {
        if (aciertos >= 5)
        {
            PlayerPrefs.SetInt("NC", PlayerPrefs.GetInt("NC", 0) + 1);
            textMessage.text = "¡FELICIDADES, ENVIASTE LAS SEÑALES CORRECTAS!\nPresiona 'R' para volver a jugar\nPresiona 'M' para continuar con tu aventura";
            PlayerPrefs.SetInt("CPUWIN", PlayerPrefs.GetInt("CPUWIN", 0) + 1);
        }
        else if (intentos <= 0)
        {
            textMessage.text = "¡PERDISTE, TE QUEDASTE SIN INTENTOS!\nPresiona 'R' para reintentar\nPresiona 'M' para volver al mapa";
        }
        else {

            if (acierto)
            {
                textMessage.text = "¡SEÑAL CORRECTA!\n Sumas un acierto\n Presiona la tecla 'Espacio' para continuar\nPresiona 'R' para reintentar\nPresiona 'M' para volver al mapa";
            } 
            else
            {
                textMessage.text = "¡SEÑAL INCORRECTA!\n Pierdes un intento\n Presiona la tecla 'Espacio' para continuar\nPresiona 'R' para reintentar\nPresiona 'M' para volver al mapa";
            }
        }
    }
}