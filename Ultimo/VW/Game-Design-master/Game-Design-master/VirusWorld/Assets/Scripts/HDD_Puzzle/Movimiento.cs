/*
Emilio Sanchez 
Rafael Rios
Edgar Rostro

Allows the player horizontal movements 
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    [SerializeField] float velocidad;

    Vector3 movimiento;

    void Update()
    {
        movimiento.x = Input.GetAxisRaw("Horizontal");
        transform.position = transform.position + movimiento * velocidad *Time.deltaTime;
    }
   
}
