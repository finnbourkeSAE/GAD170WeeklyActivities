using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Goal : MonoBehaviour
{

    public WeekSixGameManager gameManager;

    private void OnTriggerEnter(Collider other)
    {
        // here we should check to see if the tag of the object the collider is attached to is the player.
        if (other.tag == "Player")
        {
            // if the player reaches here 
            // lets tell the gamemanager they've won the game.
            // remember to check if we have a reference before accessing a function
            if (gameManager != null)
            {
               
            }
        }
    }
}

