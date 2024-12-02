using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Playermananger : MonoBehaviour
{
    public List<GameObject> playerlist; // Lista med spelare

    public List<GameObject> tiles; // Lista med alla plattor p� spelplanen

    public Dice dice;

    //public Player currentplayer;

    public int whonext = 1; // variabel som h�ller koll p� vilken spelare det �r n�st. 

    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject player in playerlist)
        {
            player.transform.position = tiles[0].transform.position; // s�tter alla spelares position till den f�rsta plattan.
        }

    }

    // Update is called once per frame
    void Update()
    {

        foreach (GameObject player in playerlist) // g�r igenom alla spelare. 
        {
            if (player.GetComponent<Player>().id == whonext) // Letar upp en spelare med samma siffra p� sitt id som siffran i whonext.
            {
                player.GetComponent<Player>().yourturn = true; // S�tter den spelarens yourturn variabel till true.

                if (dice.GetComponent<Dice>().playermoved == true) // Kollar om spelaren har flyttat p� sig.
                {
                    whonext += 1; // L�gger till ett p� whonext f�r att n�sta spelare ska spela n�sta runda.
                    dice.GetComponent<Dice>().playermoved = false; // S�tter att spelaren inte har flyttat p� sig dp det �r en ny spelare.
                    player.GetComponent<Player>().yourturn = false; // s�tter spelarens yourturn till falsk f�r att spelaren inte ska tro att det fortfarande �r dens tur.
                }
            }

            else if (player.GetComponent<Player>().id != whonext) // om spelarens id inte st�mmer �ver�ns med who next s� s�tts dens yourturn till false
            {
                player.GetComponent<Player>().yourturn = false;
            }

            /*if (player.GetComponent<Player>().pos = player.GetComponent<Player>().pos)
            {

            }*/
        }
        if (whonext >= 5) // om alla spelare har varit s� b�rjar loopen om fr�n b�rjan. 
        {
            whonext = 1;
        }
    }
}
