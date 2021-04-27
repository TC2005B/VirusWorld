/*
Emilio Sanchez 
Rafael Rios
Edgar Rostro

Creates and drops files and virus sprites 
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropElem : MonoBehaviour
{
    [SerializeField] GameObject file;
    [SerializeField] GameObject virus;
    [SerializeField] Vector2 limits;
    [SerializeField] Vector2 nlimits;
    [SerializeField] float delayF;
    [SerializeField] float delayV;

    Vector3 positionF;
    Vector3 positionV;

    // Start is called before the first frame update
    public void startDropping()
    {
        InvokeRepeating("NewFile", 1, delayF);
        InvokeRepeating("NewVirus", 1, delayV);
    }

    void NewFile()
    {
        // Generate the new random position based on the settings
        positionF = new Vector3(Random.Range(-nlimits.x, limits.x), limits.y, 0);
        Instantiate(file, positionF, Quaternion.identity);
    }

    void NewVirus()
    {
        // Generate the new random position based on the settings
        positionV = new Vector3(Random.Range(-nlimits.x, limits.x), limits.y, 0);
        Instantiate(virus, positionV, Quaternion.identity);
    }

    // This method will stop the generation of new balls
    public void StopDroppping()
    {
        CancelInvoke();
    }
}