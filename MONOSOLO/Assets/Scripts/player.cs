using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Dice dice;

    public Playermananger playermananger;

    public int id;

    public int index = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (dice.dicerolled == true)
        {

            index += dice.nummer;
            transform.position = playermananger.tiles[index].transform.position;
            dice.dicerolled = false;
        }
    }
}
