/*
Emilio Sanchez 
Rafael Rios
Edgar Rostro

Recieves user input and asigns each key a particular function 
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Inputs : MonoBehaviour
{
    [SerializeField] string scene;
    [SerializeField] Text textMessage;

    Luces luces;
    Control control;
    api apu;

    // Start is called before the first frame update
    void Start()
    {
        luces = GetComponent<Luces>();
        control = GetComponent<Control>();
        apu = GetComponent<api>();
    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(scene);
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
           StartCoroutine(apu.updateData());
            SceneManager.LoadScene("Mapa");
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            textMessage.text = "Presiona la tecla 'Enter' para mandar tu respuesta";
            luces.startGame();
            luces.player.Clear();
            luces.señal.Clear();
        }
        if (Input.GetKeyDown(KeyCode.A)) 
        {
            int a = 0;
            luces.player.Add(a.ToString());
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            int s = 1;
            luces.player.Add(s.ToString());
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            int d = 2;
            luces.player.Add(d.ToString());
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            int f = 3;
            luces.player.Add(f.ToString());
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            control.acierto = luces.comparacion();
            control.puntos();
        }
    }
}
