using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Playermananger : MonoBehaviour
{
    public List<GameObject> playerlist;

    public List<GameObject> tiles;

    public Dice dice;

    public Player p;
    // Start is called before the first frame update
    void Start()
    {
        int i = 0;
        foreach (GameObject player in playerlist)
        {
            player.transform.position = tiles[0].transform.position;
            i++;
        }

        //p = playerlist[0].GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        /*foreach (GameObject players in playerlist)
        {
            //p = players.GetComponent<Player>();
            
            if (p.id == 1)
            {
                p.index += dice.nummer;
            }
        }*/
        /*if (p.id == 1)
            {
                p.index += dice.nummer;
            }*/
        //p.index = dice.nummer;
        // kolla om id stämmer överräns med player id. Försök nå player scripten i varje player i playerlist.
    }
}
