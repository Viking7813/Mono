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

    public bool playermoved = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
    }   

    public void OnClick()
    {
        dicerolled = true; // kollar om tärningen blivit rullad
        for (int i = 0; i < 1; i++)
        {
            nummer = Random.Range(2, 13); // genererar ett random nummer mellan 2 och 12
            diceText.SetText($"You rolled: {nummer} "); // skriver ut vilket nummer du fick.
        }
    }
}
