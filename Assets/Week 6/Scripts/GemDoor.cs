using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemDoor : MonoBehaviour
{
    public int gemsRequired = 5;
    public GameObject doorParent;

    private void OnTriggerEnter(Collider other)
    {
        // cool let's check if the thing that has entered this trigger is the player
        // by comparing the tag to Player
        if (other.tag == "Player")
        {
            // then let's access the player Character script.
            // to do this we'll have to search the collider for the script, get component might be handy.
            // don't forget to check that we have a reference before accessing functions/variables.
            if (other.GetComponent<PlayerCharacter>())
            {
                // now let's check to see if the number of gems the player has
                // is the same as our door.
                if (other.GetComponent<PlayerCharacter>().numberOfGems >= 0)
                {
                    // Lets reset the player's gems by calling the Reset Gems function
                    

                    // if so then let's destroy the door parent and clear the path.
                    // we should check to see if the door parent reference exists first.
                    if (doorParent != null)
                    {
                      
                    }
                }
            }
        }
    }
}
