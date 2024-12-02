using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Playermananger : MonoBehaviour
{
    public List<GameObject> playerlist; // Lista med spelare

    public List<GameObject> tiles; // Lista med alla plattor på spelplanen

    public Dice dice;

    //public Player currentplayer;

    public int whonext = 1; // variabel som håller koll på vilken spelare det är näst. 

    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject player in playerlist)
        {
            player.transform.position = tiles[0].transform.position; // sätter alla spelares position till den första plattan.
        }

    }

    // Update is called once per frame
    void Update()
    {

        foreach (GameObject player in playerlist) // går igenom alla spelare. 
        {
            if (player.GetComponent<Player>().id == whonext) // Letar upp en spelare med samma siffra på sitt id som siffran i whonext.
            {
                player.GetComponent<Player>().yourturn = true; // Sätter den spelarens yourturn variabel till true.

                if (dice.GetComponent<Dice>().playermoved == true) // Kollar om spelaren har flyttat på sig.
                {
                    whonext += 1; // Lägger till ett på whonext för att nästa spelare ska spela nästa runda.
                    dice.GetComponent<Dice>().playermoved = false; // Sätter att spelaren inte har flyttat på sig dp det är en ny spelare.
                    player.GetComponent<Player>().yourturn = false; // sätter spelarens yourturn till falsk för att spelaren inte ska tro att det fortfarande är dens tur.
                }
            }

            else if (player.GetComponent<Player>().id != whonext) // om spelarens id inte stämmer överäns med who next så sätts dens yourturn till false
            {
                player.GetComponent<Player>().yourturn = false;
            }

            /*if (player.GetComponent<Player>().pos = player.GetComponent<Player>().pos)
            {

            }*/
        }
        if (whonext >= 5) // om alla spelare har varit så börjar loopen om från början. 
        {
            whonext = 1;
        }
    }
}
