using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour
{
    public AudioClip collectedSound;
    public AudioSource sfx;
    private void OnTriggerEnter(Collider other)
    {
        // cool let's check if the thing that has entered this trigger is the player
        // by comparing the tag to Player
        if (other.tag == "Player")
        {
            // then let's access the player Character script.
            // to do this we'll have to search the collider for the script, get component might be handy.
            // don't forget to check that we have a reference before accessing functions/variables.
            if (other.GetComponent<PlayerCharacter>() != null)
            {
                // let's increase our players number of gems by one.
            
                // let's check that we have a sound and sfx reference;
                if (sfx != null && collectedSound != null)
                {
                    //let's call the play oneshot of the sfx source and pass in the collected sound.
                    
                }
                // let's then destroy ourselves
              
            }
        }
    }
}
