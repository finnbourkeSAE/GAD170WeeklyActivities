using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerCharacter : MonoBehaviour
{
    public float health;
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI gemText;
    private Vector3 startPosition;

    public int numberOfGems;
    private WeekSixGameManager weekSixGameManager;

    public CharacterController characterController;

    // Awake is called before Start
    void Awake()
    {
        // on the first frame of the game, let's store our initial position so we can reset it later.
        startPosition = transform.position;
        // let's also search the scene for a weekSixGameManger instance, we know there's only one, so we can use FindObjectOftype
        weekSixGameManager = null;
    }

    public void AddGems()
    {
        // increase the number of gems by 1
        
        // we should also update the UI to match.
        // but also check if we have a reference first.
        if (gemText != null)
        {
            gemText.text = "gems";
        }
    }

    public void ChangeHealth(int amount)
    {
        // the amount coming in; we want to add this to our current health.
        health += 0;
        // we should also update the UI to match.
        // we should check if we have a reference to the text
        if (healthText != null)
        {
            healthText.text =  "health";
        }

        // check if we have died
        if (health <= 0)
        {
            // if we died, lets call the die function
           
        }
    }

    void Die()
    {
        // debug out that we have died.
        Debug.Log("you have died.");
        // if we die we should tell the game manager to reset the game.
        // check to see if we have a reference to the gamemanager first.
        if (weekSixGameManager != null)
        {
            // call reset game from the game manager.
            
        }
    }

    public void Reset()
    {
        // let's reset our health
    

        // call Reset Position
        ResetPosition();

        // we should reset our gems
       
    }

    public void ResetHealth()
    {
        // reset our health to 100.
    

        // we should also update the UI to match.
        //check if we have a reference first
        if (healthText != null)
        {
            healthText.text = "health";
        }
    }

    public void ResetGems()
    {
        // reset the number of gems we have to 0.
        
        // we should also update the UI to match.
        // but also check if we have a reference first.
        if (gemText != null)
        {
            gemText.text = "gems";
        }
    }

    private void ResetPosition()
    {
        // hack, so fun thing with the character controller,
        // it won't let us move stuff around...so we have to turn the script off.
        characterController.enabled = false;
        // move the object
        transform.position = startPosition;
        // then turn it back on.
        characterController.enabled = true;
    }

}