/*
Emilio Sanchez 
Rafael Rios
Edgar Rostro

It evaluates if the player completed the 3 levels and if so it displays the victory menu, otherwise it will display the loser menu
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lobbyonekenobi : MonoBehaviour
{
    Lobby scriptLobby;
    [SerializeField] GameObject menu;
    // Start is called before the first frame update
    void Start()
    {
        scriptLobby = menu.GetComponent<Lobby>();

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(PlayerPrefs.GetInt("CPUWIN", 0)>0 && PlayerPrefs.GetInt("RAMWIN", 0)>0 && PlayerPrefs.GetInt("HDDWIN", 0)>0)
        {
            scriptLobby.Victoria();
        }
        else
        {
            scriptLobby.Perdedor();
        }
    }
}
