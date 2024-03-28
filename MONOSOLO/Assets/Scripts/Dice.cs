using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Dice : MonoBehaviour
{
    // Start is called before the first frame update

    public TextMeshPro diceText;

    public int nummer = 0;

    public bool dicerolled = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (dicerolled == true)
        {
            nummer = Random.Range(0, 12);

            diceText.text = $"You rolled: {nummer} ";
        }


        else if (dicerolled == false)
        {

        }

    }   
}
