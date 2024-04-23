using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermananger : MonoBehaviour
{
    public List<GameObject> playerlist;

    public List<GameObject> tiles;

    public Dice dice; 

    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject player in playerlist)
        {
            player.transform.position = tiles[0].transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        

        foreach (GameObject obj in tiles)
        {

        }
    }
}
