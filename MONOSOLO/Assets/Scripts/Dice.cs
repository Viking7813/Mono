using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class Dice : MonoBehaviour
{
    // Start is called before the first frame update

    public TMP_Text diceText;

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
            nummer = Random.Range(2, 13);

            diceText.SetText( $"You rolled: {nummer} ") ;

            dicerolled = false;
        }


        else if (dicerolled == false)
        {

        }

    }   

    public void OnClick()
    {
        dicerolled = true;
    }
}
