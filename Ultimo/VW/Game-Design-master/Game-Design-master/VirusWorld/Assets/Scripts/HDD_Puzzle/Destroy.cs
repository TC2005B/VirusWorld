/*
Emilio Sanchez 
Rafael Rios
Edgar Rostro

It destroy the file/virus prefabs on contact with the HDD 
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col) 
    { 
        Destroy(col.gameObject); 
    } 
}
