/*
Emilio Sanchez 
Rafael Rios
Edgar Rostro

Updates and displays the number of completed levels every time it loads the main map
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PuntajeGlobal : MonoBehaviour
{
    [SerializeField] Text textMessage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CambioPuntaje()
    {
        textMessage.text = "Llevas " + PlayerPrefs.GetInt("NC", 0) + " niveles completados.";
    }
}
