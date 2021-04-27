/*
Emilio Sanchez 
Rafael Rios
Edgar Rostro

Makes the players movement possible and saves his last position in the map right before entering each level 
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    PuntajeGlobal scriptPuntaje;
    public float velocidad;

    Vector3 ubicacion;

    Vector3 defaultValue = new Vector3(-4.44f, -2.18f, 0f);
    Vector3 direccion;

    void Start()
    {
        
        //PlayerPrefs.DeleteAll();
        if (gameObject.name == "Robot")
        {
            if (PlayerPrefs.HasKey("X"))
            {
                ubicacion.x = PlayerPrefs.GetFloat("X");
                ubicacion.y = PlayerPrefs.GetFloat("Y"); 
                transform.position = ubicacion;
            }
            else
            {
                transform.position = defaultValue; 
            }
            scriptPuntaje = GetComponent<PuntajeGlobal>();
            scriptPuntaje.CambioPuntaje();
        }
        
    }
    // Registra input de direcciones y mueve al jugador
    void Update()
    {
        SpriteRenderer rendererRobot = GetComponent <SpriteRenderer> ();
        direccion.x = Input.GetAxisRaw("Horizontal");
        if (Input.GetAxisRaw("Horizontal") == -1)
        {
            rendererRobot.flipX = false;
        }
        else if (Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == 0)
        {
            rendererRobot.flipX = true;
        }
        direccion.y = Input.GetAxisRaw("Vertical");
        transform.position = transform.position + direccion * velocidad *  Time.deltaTime;
    }
}
