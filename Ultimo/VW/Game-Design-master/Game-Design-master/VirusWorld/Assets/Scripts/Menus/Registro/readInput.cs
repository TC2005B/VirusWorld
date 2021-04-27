/*
Emilio Sanchez 
Rafael Rios
Edgar Rostro

It will ask the user for input of his username and age to later store in the database
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class readInput : MonoBehaviour
{
    string inputusuario;
    int inputedad;
    // Start is called before the first frame update


    public void ReadStringInput(string s)
    {
        inputusuario = s;
        PlayerPrefs.SetString("Usuario",inputusuario);
        Debug.Log(PlayerPrefs.GetString("Usuario", "nada"));
    }


    public void ReadIntInput(string e)
    {
        inputedad = int.Parse(e);
        PlayerPrefs.SetInt("Edad",inputedad);
        Debug.Log(PlayerPrefs.GetInt("Edad", 0));
    }
}