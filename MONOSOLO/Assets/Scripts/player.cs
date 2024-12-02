using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Dice dice;

    public Playermananger playermananger;

    public int id; // håller koll vilken spelare det är.

    public int index = 0; // Håller koll på vart i spelplanen spelaren är

    public int pos = 0;

    public bool yourturn = false; // kollar om det är din tur

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (dice.dicerolled == true && dice.playermoved == false && yourturn == true)
        {
            index += dice.nummer; // Adderar det nummret du slog på tärningen till spelarens index.

            if (index >= 39)
            {
                index = math.abs(39 - index);
                pos = index;
                transform.position = playermananger.tiles[pos].transform.position; // flyttar spelaren till positionen av den plattan indexen är satt till.
            }

            else if (index < 39)
            {
                pos = index;
                transform.position = playermananger.tiles[pos].transform.position; // flyttar spelaren till positionen av den plattan indexen är satt till.
            }

            dice.dicerolled = false;
            dice.playermoved = true; 
        }
    }
}
