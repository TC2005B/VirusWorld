/*
Emilio Sanchez 
Rafael Rios
Edgar Rostro

Changes the sprite of the light to 4 different random colors
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Luces : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    [SerializeField] Sprite[] luces;

    public ArrayList señal = new ArrayList();
    public ArrayList player = new ArrayList();

    public void startGame()
    {
        for (float i = 0f; i <= UnityEngine.Random.Range(4, 6); i++)
        {
            Invoke("changeSprite", i);
            Invoke("restartSprite", i+0.5f);
        }
    }

    void restartSprite()
    {
        spriteRenderer.sprite = luces[4];
    }

    void changeSprite()
    {
        int rand = UnityEngine.Random.Range(0, luces.Length-1);
        spriteRenderer.sprite = luces[rand];
        señal.Add(rand.ToString());
    }

    public bool comparacion()
    {
        if(señal.Count == 0 || player.Count == 0)
        {
            return false;
        }
        else
        {
            for (int i = 0; i < señal.Count; i++)
            {
            if (!señal[i].Equals(player[i]))
                {
                return false;
                }
            }
            return true;
        }
    }
}
