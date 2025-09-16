using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealDamage : MonoBehaviour
{

    public int damage = -20;

    private void OnCollisionEnter(Collision collision)
    {
        // check to see if we hit the player by comparing the tag
        // remember you'll need to access the gameobject of the collision, to then be able to access the tag
        if (collision.gameObject.tag == "Player")
        {
            // let's get a reference to the player character script
            PlayerCharacter playerCharacter = null;

            // let's check that it's not null before we try to access it.
            if (playerCharacter != null)
            {
                // let's access the change health function of the player.
                // then pass in our damage to the function
             
            }
        }
    }
}
